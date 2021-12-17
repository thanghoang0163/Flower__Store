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
                    string id = txtId.Text;
                    string pass = txtPassword.Text;
                    string sql = "select * from SIGNIN where IDEMP = '" + id + "' and PASSWORDSI = '" + pass + "'";
                    command = new SqlCommand(sql, connection);
                    SqlDataReader data = command.ExecuteReader();
                    if(data.Read() == true)
                    {
                        MainMenu mainmenu = new MainMenu();
                        mainmenu.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("The employee is not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
