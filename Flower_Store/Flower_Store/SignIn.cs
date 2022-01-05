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
using System.Runtime.InteropServices;

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
                    string sql = "select * from SIGNIN where USERNAME = '" + username + "' and PASSWORDSI = '" + pass + "'";
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter key pressed");
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void SignIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
