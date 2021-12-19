using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flower_Store
{
    public partial class SupplierManagement : Form
    {
        public SupplierManagement()
        {
            InitializeComponent();
        }

        private void dtpSupplier_ValueChanged(object sender, EventArgs e)
        {
            dtpSupplier.CustomFormat = "ddd, dd/MMM/yyyy  hh:mm";
        }
    }
}
