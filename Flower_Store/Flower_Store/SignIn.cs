using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Flower_Store
{
    public partial class SignIn : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string strCon = @"Data Source=DESKTOP-BPPFG9F;Initial Catalog=FLOWERSTORE;Integrated Security=True";
       

       
        public SignIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtId.Text = "admin";
            txtPassword.Text = "123";
            txtId.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection == null)
                {
                    connection = new SqlConnection(strCon);
                }

                
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string username  = txtId.Text;
                    string pass = txtPassword.Text;
                    string sql = "select * from SIGNIN where USERNAME = '" + username + "' and PASSWORD = '" + pass + "'";
                    command = new SqlCommand(sql, connection);
                    SqlDataReader data = command.ExecuteReader();
                    if(data.Read() == true)
                    {
                        MainMenu mainmenu = new MainMenu();
                        mainmenu.Show();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("The employee is not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
