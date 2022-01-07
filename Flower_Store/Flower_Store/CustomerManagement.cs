using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
namespace Flower_Store
{
    public partial class CustomerManagement : Form
    {
        public CustomerManagement()
        {
            InitializeComponent();
            dtpCustomer.Value = new DateTime(2021, 01, 01);
        }
        private void clearData()
        {
            txtId.Text = "";
            txtAddress.Text = ""; //Address
            txtPhone.Text = ""; //Supplier
            txtCustomer.Text = ""; //Product:
            dtpCustomer.Text = ""; //Phone
            rBtnMale.Checked = true;
            dtpCustomer.Value = new DateTime(2021, 01, 01);
        }
        SqlConnection connection;
        string strCon = @"Data Source=DESKTOP-BPPFG9F;Initial Catalog=FLOWERSTORE;Integrated Security=True";
        private void connectDb()
        {
            if (glbVar.isGetCustomer == false)
            {
                btnSubmit.Visible = false;
            }
            if (glbVar.isGetCustomer == true || glbVar.isGetCustomerForInvoice)
            {
                btnSubmit.Visible = true;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddress.Text != "" && txtPhone.Text != "" && txtCustomer.Text != "")
                {
                    connection.Open();
                    {
                        string gender;
                        if (rBtnFemale.Checked)
                            gender = rBtnFemale.Text;
                        else
                            gender = rBtnMale.Text;
                        string sql = "insert into CUSTOMER (NAMECUS,GENDER,PHONE,ADDRESSCUS,BIRTHDAY) values('" + txtCustomer.Text + "','" + gender + "','" + txtPhone.Text + "','" + txtAddress.Text + "','" + dtpCustomer.Value.ToString("dd/MM/yyyy") + "')";
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
                    string sql = "update CUSTOMER set NAMECUS ='" + txtCustomer.Text + "', GENDER = '" + gender + "', PHONE='" + txtPhone.Text + "', ADDRESSCUS = '" + txtAddress.Text + "' , BIRTHDAY = '" + dtpCustomer.Value.ToString("dd/MM/yyyy") + "'  where idcus = '" + txtId.Text + "'";
                    SqlCommand com = new SqlCommand(sql, connection);
                    int result = (int)com.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Update success!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DateTime dt = DateTime.ParseExact(dgvCustomer.CurrentRow.Cells[6].Value.ToString(), "dd/MM/yyyy",CultureInfo.InvariantCulture);
            dtpCustomer.Value = dt;
            if (glbVar.isGetCustomer == true || glbVar.isGetCustomerForInvoice == true)
            {
                glbVar.customer = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
                glbVar.idCustomer = Int32.Parse(dgvCustomer.CurrentRow.Cells[1].Value.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Are you Sure?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (message == DialogResult.OK)
            {
                connection.Open();
                string sql = "delete from CUSTOMER where IDCUS = '" + txtId.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete success!.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                connectDb();
                clearData();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (glbVar.isGetCustomer)
            {

                InvoiceManagement invoice = new InvoiceManagement();
                invoice.Show();
                this.Close();
            }
            else
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
            if (glbVar.isGetCustomer)
            {

                InvoiceManagement invoice = new InvoiceManagement();
                invoice.Show();
                this.Close();
            }
            else
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

        private void btnFind_Click(object sender, EventArgs e)
        {

            connection.Open();
            string gender;
            if (rBtnFemale.Checked)
                gender = rBtnFemale.Text;
            else
                gender = rBtnMale.Text;
            string sql = "SELECT * from CUSTOMER ";
            if (txtAddress.Text != "" || txtCustomer.Text != "" || txtPhone.Text != "")
                sql += " where "; 
            if (txtCustomer.Text != "" )
                sql += " NAMECUS ='" + txtCustomer.Text + "' AND GENDER = '" + gender + "'" ;
            if (txtPhone.Text != "")
                sql += " AND PHONE='" + txtPhone.Text + "'" ;
            if (txtAddress.Text != "")
                sql += " AND ADDRESSCUS = '" + txtAddress.Text + "' AND BIRTHDAY = '" + dtpCustomer.Value.ToString("dd/MM/yyyy") + "'";
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Connection error" + ex.Message);
                connection.Close();
            }
  
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (glbVar.isGetCustomer == true)
            {
                OderManagement oder = new OderManagement();
                oder.Show();
                this.Close();
            }
            if(glbVar.isGetCustomerForInvoice == true)
            {
                InvoiceManagement oder = new InvoiceManagement();
                oder.Show();
                this.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            connection.Open();
            string gender;
            if (rBtnFemale.Checked)
                gender = rBtnFemale.Text;
            else
                gender = rBtnMale.Text;
            string sql = "SELECT * from CUSTOMER ";
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Connection error" + ex.Message);
                connection.Close();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
