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
    public partial class WholesaleDash : Form
    {
        public WholesaleDash()
        {
            InitializeComponent();
        }

        private void closeApplicationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();

            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WholesaleDash_Load(object sender, EventArgs e)
        {
            dataGridViewAdminSales.Columns.Add("ID", "ID");
            dataGridViewAdminSales.Columns.Add("Product", "Product");
            dataGridViewAdminSales.Columns.Add("Quantity", "Quantity");



            dataGridViewAdminSales.Columns.Add("ID", "ID");
            dataGridViewAdminSales.Columns.Add("Product", "Product");
            dataGridViewAdminSales.Columns.Add("Quantity", "Quantity");

            // Add sample rows (no duplicates)
            dataGridViewAdminSales.Rows.Add(1, "Chicken Breast 1kg", 50);
            dataGridViewAdminSales.Rows.Add(2, "Whey Powder 1kg", 30);
            dataGridViewAdminSales.Rows.Add(3, "Bread", 20);
            dataGridViewAdminSales.Rows.Add(4, "Milk", 8);

            dataGridViewAdminSales.Rows.Add(1, "Chicken Breast 1kg", 50);
            dataGridViewAdminSales.Rows.Add(2, "Whey Powder 1kg", 30);
            dataGridViewAdminSales.Rows.Add(3, "Bread", 20);
            dataGridViewAdminSales.Rows.Add(4, "Milk", 8);
        }

        private void btnDispatch_Click(object sender, EventArgs e)
        {
            string url = "https://www.coolrunning.co.za/booking-form.html"; //this is a mock patner company that delivers our goods to the user. After admin filled in the delivery details of customer in that booking form, he tracks status there and is able to mark a certain order as delivered back in our app

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the link. Error: " + ex.Message);
            }
        }
    }
}
