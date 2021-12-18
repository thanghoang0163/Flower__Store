using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flower_Store
{
    public partial class InvoiceManagement : Form
    {
        public InvoiceManagement()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtpInvoice_ValueChanged(object sender, EventArgs e)
        {
            dtpInvoice.CustomFormat = "ddd, dd/MM/yyyy  hh:mm";
        }
    }
}
