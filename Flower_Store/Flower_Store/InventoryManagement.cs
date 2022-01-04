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
    public partial class InventoryManagement : Form
    {
        public InventoryManagement()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        string strCon = @"Data Source=DESKTOP-BPPFG9F;Initial Catalog=FLOWERSTORE;Integrated Security=True";
        private void connectDb()
        {
            connection = new SqlConnection(strCon);
            connection.Open();
            string sql = "select * from INVENTORY";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, connection); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            connection.Close();  // đóng kết nối
            dgvInventory.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            connectDb();
        }
        private void clearData()
        {
            txtProduct.Text = "";
            txtId.Text = "";
            txtRemainingQuantity.Text = "";
            txtSoldQuantity.Text = "";
            txtTotalQuantity.Text = "";
            txtUnitprice.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProduct.Text != "" && txtUnitprice.Text != "" && txtRemainingQuantity.Text != "" && txtSoldQuantity.Text != "" )
                {
                    connection.Open();
                    string sql = "insert into INVENTORY (PRODUCT, UNITPRICE, SOLDQUANTITY, REMANININGQUANTITY, TOTALQUANTITY) values('" + txtProduct.Text + "', '" + txtUnitprice.Text + "',' " + txtSoldQuantity.Text + "',' " + txtRemainingQuantity.Text + "',' " + txtTotalQuantity.Text + "')";
                    SqlCommand com = new SqlCommand(sql, connection);
                    int result = (int)com.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Inventory added.");
                        connection.Close();
                        connectDb();
                        clearData();
                    }
                    else
                        MessageBox.Show("Add failed.");
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
                MessageBox.Show("Connection error." + ex.Message);
                connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProduct.Text != "" && txtUnitprice.Text != "" && txtRemainingQuantity.Text != "" && txtSoldQuantity.Text != "" )
                {
                    connection.Open();
                    string sql = "update INVENTORY set PRODUCT = '" + txtProduct.Text + "' , UNITPRICE = '" + txtUnitprice.Text + "', SOLDQUANTITY = '" + txtSoldQuantity.Text + "', REMANININGQUANTITY = '" + txtSoldQuantity.Text + "', TOTALQUANTITY ='" + txtTotalQuantity.Text + "' where idprod = '" + txtId.Text + "'";
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
                        MessageBox.Show("Update failed.");
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
                MessageBox.Show("Connection error." + ex.Message);
                connection.Close();
            }
        }

        private void dgvInventory_Click(object sender, EventArgs e)
        {
            txtId.Text = dgvInventory.CurrentRow.Cells[1].Value.ToString();
            txtProduct.Text = dgvInventory.CurrentRow.Cells[2].Value.ToString();
            txtRemainingQuantity.Text = dgvInventory.CurrentRow.Cells[5].Value.ToString();
            txtSoldQuantity.Text = dgvInventory.CurrentRow.Cells[4].Value.ToString();
            txtTotalQuantity.Text = dgvInventory.CurrentRow.Cells[6].Value.ToString();
            txtUnitprice.Text = dgvInventory.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            connectDb();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Are you Sure?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (message == DialogResult.OK)
            {
                connection.Open();
                string sql = "delete from inventory where IDPROD = '" + txtId.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete success!");
                connection.Close();
                connectDb();
                clearData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void InventoryManagement_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
