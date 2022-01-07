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
    public partial class InvoiceManagement : Form
    {
        public InvoiceManagement()
        {
            InitializeComponent();
        }
        glbVar getFunction = new glbVar();
        SqlConnection connection;
        string strCon = @"Data Source=DESKTOP-BPPFG9F;Initial Catalog=FLOWERSTORE;Integrated Security=True";
        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            glbVar.isGetCustomerForInvoice = true;
            CustomerManagement customer = new CustomerManagement();
            customer.Show();
            this.Hide();
        }
        private void connectDb()
        {
            if(glbVar.isGetProductForInvoice == true)
            {
              
            }    
            connection = new SqlConnection(strCon);
            connection.Open();
            string sql = "select * from ORDERS WHERE idcus ='" + glbVar.idCustomer + "'";
            SqlCommand com = new SqlCommand(sql, connection);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dgvInvoice.Rows.Count - 1; i++)
            {
                dgvInvoice.Rows[i].Cells["STT"].Value = (i + 1);
            }
            connection.Close();
            dgvInvoice.DataSource = dt;
            getFunction.setDefaultvalue();
        }

        private void dtpInvoice_ValueChanged(object sender, EventArgs e)
        {
            //dtpInvoice.CustomFormat = "ddd, dd/MMM/yyyy  hh:mm";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            glbVar.isGetCustomerForInvoice = false;
            this.Close();
        }
        private void clearData()
        {
            txtId.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    connection.Open();
                    string sql = "insert into employee (IDCUS, PRODUCT, IDOD, IDEMP, TOTAL, INVOICEDATE) values('')";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            glbVar.isGetCustomerForInvoice = false;
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

        private void InvoiceManagement_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    

        private void InvoiceManagement_Load(object sender, EventArgs e)
        {
            connectDb();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
    }
}
