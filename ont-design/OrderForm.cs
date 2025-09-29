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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void labelforAddress_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelForPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void linkToExitOrderPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {

            // get customer details form data
            Payment pay = new Payment();
            pay.Show();
            this.Close();
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {


            // fake data to moved to offred products method


            // check if a product is selected
            if (offredProductsListBox.SelectedItem != null)
            {
                string product = offredProductsListBox.SelectedItem.ToString();
                int quantity = (int)numericUpDownForQauantity.Value;


                string cartItem = $"{product} - Qty: {quantity}";

                // add to cart
                cartListBox.Items.Add(cartItem);
            }
            else
            {
                MessageBox.Show("Please select a product before adding to the cart.", "No Product Selected",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panelForProductDetails_Paint(object sender, PaintEventArgs e)
        {

            // for testing purposes
            offredProductsListBox.Items.Add("Milk");
            offredProductsListBox.Items.Add("Eggs");
            offredProductsListBox.Items.Add("Whey");
        }
    }
}
