using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Flower_Store
{
    public partial class EmployeeManagement : Form
    {
        
        SqlConnection connection;
        string strCon = @"Data Source=DESKTOP-BPPFG9F;Initial Catalog=FLOWERSTORE;Integrated Security=True";

        private void connectDb()
        {
            connection = new SqlConnection(strCon);
            connection.Open();
            string sql = "select * from EMPLOYEE";  
            SqlCommand com = new SqlCommand(sql, connection); 
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); 
            DataTable dt = new DataTable(); 
            da.Fill(dt);  
            connection.Close();  
            dgvEmployee.DataSource = dt;
            for (int i = 0; i < dgvEmployee.Rows.Count -1 ; i++)
            {
                dgvEmployee.Rows[i].Cells["STT"].Value = (i + 1);

            }
        }

        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void clearData()
        {
            txtId.Text = "";
            txtEmployee.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmployee.Text != "" && txtPhone.Text != "" && txtSalary.Text != "")
                {
                    connection.Open();
                    string sql = "insert into employee (NAMEEMP, PHONE, SALARY) values('" + txtEmployee.Text + "', '" + txtPhone.Text + "',' " + txtSalary.Text + "')";
                    SqlCommand com = new SqlCommand(sql, connection);
                    int result = (int)com.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Employee added");
                        connection.Close();
                        connectDb();
                        clearData();
                    }
                    else

                        MessageBox.Show("Add failed");
                    connection.Close();


                }
                else
                {
                    MessageBox.Show("Please fill out the information completely!");
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error" + ex.Message);
                connection.Close();
            }
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            connectDb();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmployee.Text != "" && txtPhone.Text != "" && txtSalary.Text != "")
                {
                    connection.Open();
                    string sql = "update employee set nameemp = '" + txtEmployee.Text + "', phone = '" + txtPhone.Text + "', salary = '" + txtSalary.Text + "' where idemp = '" + txtId.Text + "'";
                    SqlCommand com = new SqlCommand(sql, connection);
                    int result = (int)com.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Update success!");
                        connection.Close();
                        connectDb();
                        clearData();
                    }
                    else
                        MessageBox.Show("Update failed");
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Please fill out the information completely!");
                    connection.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error" + ex.Message);
                connection.Close();

            }
        }

        private void dgvEmployee_Click(object sender, EventArgs e)
        {
            txtId.Text = dgvEmployee.CurrentRow.Cells[1].Value.ToString();
            txtEmployee.Text = dgvEmployee.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgvEmployee.CurrentRow.Cells[3].Value.ToString();
            txtSalary.Text = dgvEmployee.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Are you Sure?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (message == DialogResult.OK)
            {
                connection.Open();
                string sql = "delete from Employee where IDEMP = '" + txtId.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete success!");
                connection.Close();
                connectDb();
                clearData();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            connectDb();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximized.BackgroundImage = Properties.Resources.minimize__1_;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximized.BackgroundImage = Properties.Resources.maximize;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void EmployeeManagement_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
