using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Flower_Store
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void SupplierMenu_Click(object sender, EventArgs e)
        {
            SupplierManagement supplier = new SupplierManagement();
            supplier.Show();
        }

        private void EmployeeMenu_Click(object sender, EventArgs e)
        {
            EmployeeManagement employee = new EmployeeManagement();
            employee.Show();
        }

        private void CustomerMenu_Click(object sender, EventArgs e)
        {
            CustomerManagement customer = new CustomerManagement();
            customer.Show();
        }

        private void InventoryMenu_Click(object sender, EventArgs e)
        {
            InventoryManagement inventory = new InventoryManagement();
            inventory.Show();
        }

        private void ReportMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void HelpMenu_Click(object sender, EventArgs e)
        {
            InvoiceManagement invoice = new InvoiceManagement();
            invoice.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
