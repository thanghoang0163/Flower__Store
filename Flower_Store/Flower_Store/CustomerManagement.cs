using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Export_Report;
using System.Data.SqlClient;

namespace Flower_Store
{
    public partial class CustomerManagement : Form
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }
        private void clearData()
        {
            txtId.Text = "";
            txtAddress.Text = ""; //Address
            txtPhone.Text = ""; //Supplier
            txtCustomer.Text = ""; //Product:
            dtpCustomer.Text = ""; //Phone
            rBtnMale.Checked = true;
        }
        SqlConnection connection;
        string strCon = @"Data Source=DESKTOP-BPPFG9F;Initial Catalog=FLOWERSTORE;Integrated Security=True";
        private void connectDb()
        {
            connection = new SqlConnection(strCon);
            connection.Open();
            string sql = "select * from Customer";
            SqlCommand com = new SqlCommand(sql, connection);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            dgvCustomer.DataSource = dt;
            for (int i = 0; i < dgvCustomer.Rows.Count - 1; i++)
            {
                dgvCustomer.Rows[i].Cells["STT"].Value = (i + 1);

            }
        }
        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            connectDb();
        }

        private void dtpCustomer_ValueChanged(object sender, EventArgs e)
        {
            dtpCustomer.CustomFormat = "dd/MMM/yyyy";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
          
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void CustomerManagement_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddress.Text != "" && txtPhone.Text != ""  && txtCustomer.Text != "" )
                {
                    connection.Open();
                    {
                        string gender;
                        if (rBtnFemale.Checked)
                            gender = rBtnFemale.Text;
                        else
                            gender = rBtnMale.Text;
                        string sql = "insert into CUSTOMER (NAMECUS,GENDER,PHONE,ADDRESSCUS,BIRTHDAY) values('" + txtCustomer.Text + "','" +gender + "','"  + txtPhone.Text + "','" + txtAddress.Text + "','" + dtpCustomer.Value + "')";
                        SqlCommand com = new SqlCommand(sql, connection);
                        int result = (int)com.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Customer added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connection.Close();
                            connectDb();
                            clearData();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out the information completely!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddress.Text != "" && txtPhone.Text != "" && txtCustomer.Text != "")
                {
                    connection.Open();
                    string gender;
                    if (rBtnFemale.Checked)
                        gender = rBtnFemale.Text;
                    else
                        gender = rBtnMale.Text;
                    string sql = "update CUSTOMER set NAMECUS ='" + txtCustomer.Text + "', GENDER = '" + gender + "', PHONE='" + txtPhone.Text + "'  where idcus = '" + txtId.Text + "'";
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error" + ex.Message);
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
            txtCustomer.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
            if (dgvCustomer.CurrentRow.Cells[3].Value.ToString() == "Male")
            {
                rBtnMale.Checked = true;
                rBtnFemale.Checked = false;
            }
            else
            {
                rBtnFemale.Checked = true;
                rBtnMale.Checked = false;
            }    
             
        }
    }
}
