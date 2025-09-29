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
    public partial class UpdateStockCount : Form
    {
        public UpdateStockCount()
        {
            InitializeComponent();
        }

        private void UpdateStockCount_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelToExitProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
