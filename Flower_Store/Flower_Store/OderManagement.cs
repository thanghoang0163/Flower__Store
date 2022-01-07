using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Flower_Store
{
    public partial class OderManagement : Form
    {
        glbVar getFunction = new glbVar();
        SqlConnection connection;
        string strCon = @"Data Source=DESKTOP-BPPFG9F;Initial Catalog=FLOWERSTORE;Integrated Security=True";
        private void getCustomer_Click(object sender, EventArgs e)
        {
            glbVar.getQuantity = txtQuantity.Text;
            glbVar.getUnitprice = txtUnitprice.Text;
            glbVar.isGetCustomer = true;
            CustomerManagement customer = new CustomerManagement();
            customer.Show();
            this.Hide();
        }
        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            glbVar.getQuantity = txtQuantity.Text;
            glbVar.getUnitprice = txtUnitprice.Text;
            glbVar.isGetProductForOrders = true;
            InventoryManagement product = new InventoryManagement();
            product.Show();
            this.Hide();
        }
        public OderManagement()
        {
            InitializeComponent();
        }
       
        private void clearData()
        {
            txtIdOrder.Text = "";
            txtCustomer.Text = ""; //Address
            txtIdCustomer.Text = ""; //Supplier
            txtIdProduct.Text = ""; //Product:
            txtProduct.Text = ""; //Phone
            txtQuantity.Text = ""; //Phone
            txtTotalprice.Text = ""; //Phone
            txtUnitprice.Text = ""; //Phone
        }

        private void connectDb()
        {
            if (glbVar.isGetProductForOrders == true || glbVar.isGetCustomer == true)
            {
                txtQuantity.Text = glbVar.getQuantity;
                txtUnitprice.Text = glbVar.getUnitprice;
                txtProduct.Text = glbVar.product;
                txtIdProduct.Text = glbVar.idProduct.ToString();
                txtCustomer.Text = glbVar.customer;
                txtIdCustomer.Text = glbVar.idCustomer.ToString();
            }
            //if (glbVar.isGetCustomer == true)
            //{
            //    txtQuantity.Text = glbVar.getQuantity;
            //    txtUnitprice.Text = glbVar.getUnitprice;
            //    txtCustomer.Text = glbVar.customer;
            //    txtIdCustomer.Text = glbVar.idCustomer.ToString();
            //    txtProduct.Text = glbVar.product;
            //    txtIdProduct.Text = glbVar.idProduct.ToString();
            //}
            connection = new SqlConnection(strCon);
            connection.Open();
            string sql = "select * from orders ";
            SqlCommand com = new SqlCommand(sql, connection);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            dgvOrder.DataSource = dt;
            for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
            {
                dgvOrder.Rows[i].Cells["STT"].Value = (i + 1);
            }
          
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void OderManagement_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void OderManagement_Load(object sender, EventArgs e)
        {
            connectDb();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomer.Text != "" && txtProduct.Text != "" )
                {
                    connection.Open();
                    {
                        string sql = "insert into ORDERS (IDCUS ,CUSTOMER ,IDPROD ,PRODUCT ,QUANTITY ,UNITPRICE ,TOTALPRICE, PURCHASEDATE) values" +
                            "('" + txtIdCustomer.Text + "','" + txtCustomer.Text + "','" + txtIdProduct.Text + "','" + txtProduct.Text + "','" + txtQuantity.Text + "','" + txtUnitprice.Text + "','" + txtTotalprice.Text + "','" + dtpOrder.Value.ToString("dd/MM/yyyy") + "')";
                        SqlCommand com = new SqlCommand(sql, connection);
                        int result = (int)com.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Order added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (txtCustomer.Text != "" && txtCustomer.Text != "" && txtProduct.Text != "")
                {
                    connection.Open();
                    string sql = "update CUSTOMER set  IDCUS = '" +txtIdCustomer.Text +"', CUSTOMER = '" + txtCustomer.Text +"', IDPROD = '" + txtIdProduct.Text +"', PRODUCT = '" + txtProduct.Text +"', QUANTITY = '" + txtQuantity.Text +"', UNITPRICE = '" + txtUnitprice.Text +"', TOTALPRICE = '" + txtTotalprice +"'";
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

        private void OderManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            getFunction.setDefaultvalue();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
    }
}
