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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelToExitProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Close();
        }

        private void PaymentSubmition_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Payment Successful",          
                "Payment Status",               
                MessageBoxButtons.OK,          
                MessageBoxIcon.Information      
            );

            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

    }
}
