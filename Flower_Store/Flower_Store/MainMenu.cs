using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
