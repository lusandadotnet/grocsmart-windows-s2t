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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeApplicationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            loginForm.Show();

            this.Close();
        }

        private void linkLabelsToOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void buttonForNewOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Close();
        }

        private void buttonForNewProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Close();
        }

        private void dataGridViewForRecentProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // connect added products here
        }

        private void dataGridViewForRecentOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // connect recently ordered products here 


        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // fake data for recent orders


            dataGridViewForRecentOrders.Columns.Add("Product", "Product");
            dataGridViewForRecentOrders.Columns.Add("Quantity", "Quantity");
            dataGridViewForRecentOrders.Columns.Add("Order Date", "Order Date");

            dataGridViewForRecentOrders.Rows.Add(DateTime.Now.ToShortDateString(), "Chicken Breast 1kg", 50);
            dataGridViewForRecentOrders.Rows.Add(DateTime.Now.AddDays(-1).ToShortDateString(), "Whey Powder 1kg", 30);
            dataGridViewForRecentOrders.Rows.Add(DateTime.Now.AddDays(-2).ToShortDateString(), "Bread", 20);



            dataGridViewStock.Columns.Add("Expiry Date", "Expiry Date");
            dataGridViewStock.Columns.Add("Product", "Product");
            dataGridViewStock.Columns.Add("Quantity", "Quantity");

            dataGridViewStock.Rows.Add("Chicken Breast 1kg", 50, DateTime.Now.ToShortDateString());
            dataGridViewStock.Rows.Add("Chicken Breast 1kg", 50, DateTime.Now.ToShortDateString());
            dataGridViewStock.Rows.Add("Chicken Breast 1kg", 50, DateTime.Now.ToShortDateString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            UpdateStockCount update = new UpdateStockCount();
            update.Show();
            this.Hide();
        }
    }
}
