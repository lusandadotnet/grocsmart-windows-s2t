using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ont_design
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void linkLabelToExitProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void cancelButtonProductPage_Click(object sender, EventArgs e)
        {
            productNameTextBox.Clear();
            productPriceTextBox.Clear();
            productTypeComboBox.SelectedIndex = -1;
            availableStockTextBox.Clear();
        }

        private void productPriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
