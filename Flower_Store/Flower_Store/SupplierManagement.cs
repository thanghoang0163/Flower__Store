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
    public partial class SupplierManagement : Form
    {
        SqlConnection connection;
        string strCon = @"Data Source=DESKTOP-BPPFG9F;Initial Catalog=FLOWERSTORE;Integrated Security=True";
        private void connectDb()
        {
            connection = new SqlConnection(strCon);
            connection.Open();
            string sql = "select * from SUPPLIER";
            SqlCommand com = new SqlCommand(sql, connection);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            dgvSupplier.DataSource = dt;
            //dgvSupplier.Columns["IDPROD"].Visible = false;
            for (int i = 0; i < dgvSupplier.Rows.Count - 1; i++)
            {
                dgvSupplier.Rows[i].Cells["STT"].Value = (i + 1);

            }
        }
        public SupplierManagement()
        {
            InitializeComponent();
        }
        private void clearData()
        {
            txtId.Text = "";
            txtAddress.Text = ""; //Address
            txtPhone.Text = ""; //Supplier
            txtProduct.Text = ""; //Quantity:
            txtQuantity.Text = ""; //Unit Price:
            txtSupplier.Text = ""; //Product:
            txtTotalprice.Text = ""; //Total Price:
            txtUnitprice.Text = ""; //Phone
            dtpSupplier.Text = "";
        }
        private void dtpSupplier_ValueChanged(object sender, EventArgs e)
        {
            dtpSupplier.CustomFormat = "ddd, dd/MMM/yyyy  hh:mm";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int getInventoryId()
        {
            SqlDataReader dataReader;
            int id = 0;
            string getIdprod = "select IDPROD from INVENTORY where PRODUCT = '" + txtProduct.Text + "'";
            SqlCommand com = new SqlCommand(getIdprod , connection);
            dataReader = com.ExecuteReader();
            if (dataReader.Read() == true)
            {
                id = 1;
                while (dataReader.Read())
                {
                    id = dataReader.GetInt32(0);
                }
            }
            else
            {
                id = 0 ;
            }    
            dataReader.Close();
            return id;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddress.Text != "" && txtPhone.Text != "" && txtProduct.Text != "" && txtQuantity.Text != "" && txtSupplier.Text != "")
                {
                    connection.Open();
                    if (getInventoryId() == 0)
                    {
                        MessageBox.Show("The product is not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string sql = "insert into SUPPLIER (NAMESUPP, PHONE, ADDRESSSUPP, IDPROD, PRODUCT, QUANTITY, UNITPRICE, TOTALPRICE, SUPPLYDATE) values('" +
 txtSupplier.Text + "', '" + txtPhone.Text + "',' " + txtAddress.Text + "','" + getInventoryId() + "','" + txtProduct.Text + "', '" + txtQuantity.Text + "', '" + txtQuantity.Text + "', '" + txtUnitprice.Text + "', '" + dtpSupplier.Text + "')";
                        SqlCommand com = new SqlCommand(sql, connection);
                        int result = (int)com.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Supplier added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            connection.Close();
                            connectDb();
                            clearData();
                        }
                        else
                            MessageBox.Show("Add failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void SupplierManagement_Load(object sender, EventArgs e)
        {
            connectDb();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddress.Text != "" && txtPhone.Text != "" && txtProduct.Text != "" && txtQuantity.Text != "" && txtSupplier.Text != "" && txtTotalprice.Text != "")
                {
                    connection.Open();
                    if (getInventoryId() == 0)
                    {
                        MessageBox.Show("The product is not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string sql = "update SUPPLIER set NAMESUPP ='" + txtSupplier.Text + "', PHONE = '" + txtPhone.Text + "', ADDRESSSUPP='" + txtAddress.Text + "' , IDPROD ='  5' , PRODUCT = '" + txtProduct.Text + "', QUANTITY = '" + txtQuantity.Text + "', UNITPRICE = '" + txtUnitprice.Text + "', TOTALPRICE= '" + txtTotalprice.Text + "', SUPPLYDATE = '" + dtpSupplier.Text + "'  where idsupp = '" + txtId.Text + "'";
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
                    }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Are you Sure?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (message == DialogResult.OK)
            {
                connection.Open();
                string sql = "delete from SUPPLIER where IDSUPP = '" + txtId.Text + "'";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void SupplierManagement_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvSupplier.CurrentRow.Cells[1].Value.ToString();
            txtSupplier.Text = dgvSupplier.CurrentRow.Cells[2].Value.ToString();
            txtProduct.Text = dgvSupplier.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = dgvSupplier.CurrentRow.Cells[4].Value.ToString();
            txtQuantity.Text = dgvSupplier.CurrentRow.Cells[6].Value.ToString();
            txtPhone.Text = dgvSupplier.CurrentRow.Cells[3].Value.ToString();
            txtUnitprice.Text = dgvSupplier.CurrentRow.Cells[7].Value.ToString();
            txtTotalprice.Text = dgvSupplier.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
    }
}
