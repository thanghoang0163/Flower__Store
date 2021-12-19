using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flower_Store
{
    public partial class CustomerManagement : Form
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {

        }

        private void dtpCustomer_ValueChanged(object sender, EventArgs e)
        {
            dtpCustomer.CustomFormat = "ddd, dd/MMM/yyyy  hh:mm";
        }
    }
}
