namespace ont_design
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panelNavBar = new Panel();
            closeApplicationLinkLabel = new LinkLabel();
            labelforAdminHeading = new Label();
            pictureBoxForLogoDashBoard = new PictureBox();
            panelSideBar = new Panel();
            logoutButton = new Button();
            linkLabel2 = new LinkLabel();
            pictureBoxForInventoryVector = new PictureBox();
            linkLabelsToOrder = new LinkLabel();
            pictureBoxForOrderVector = new PictureBox();
            dataGridViewForRecentOrders = new DataGridView();
            button2 = new Button();
            label1 = new Label();
            dataGridViewStock = new DataGridView();
            addedProductsLabel = new Label();
            panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForLogoDashBoard).BeginInit();
            panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForInventoryVector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForOrderVector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForRecentOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).BeginInit();
            SuspendLayout();
            // 
            // panelNavBar
            // 
            panelNavBar.BackColor = Color.Transparent;
            panelNavBar.Controls.Add(closeApplicationLinkLabel);
            panelNavBar.Controls.Add(labelforAdminHeading);
            panelNavBar.Controls.Add(pictureBoxForLogoDashBoard);
            panelNavBar.Location = new Point(2, 5);
            panelNavBar.Name = "panelNavBar";
            panelNavBar.Size = new Size(876, 85);
            panelNavBar.TabIndex = 0;
            panelNavBar.Paint += panel1_Paint;
            // 
            // closeApplicationLinkLabel
            // 
            closeApplicationLinkLabel.AutoSize = true;
            closeApplicationLinkLabel.DisabledLinkColor = Color.White;
            closeApplicationLinkLabel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeApplicationLinkLabel.LinkColor = Color.Red;
            closeApplicationLinkLabel.Location = new Point(815, 4);
            closeApplicationLinkLabel.Name = "closeApplicationLinkLabel";
            closeApplicationLinkLabel.Size = new Size(54, 20);
            closeApplicationLinkLabel.TabIndex = 3;
            closeApplicationLinkLabel.TabStop = true;
            closeApplicationLinkLabel.Text = "Close";
            closeApplicationLinkLabel.LinkClicked += closeApplicationLinkLabel_LinkClicked;
            // 
            // labelforAdminHeading
            // 
            labelforAdminHeading.AutoSize = true;
            labelforAdminHeading.BackColor = Color.Black;
            labelforAdminHeading.Font = new Font("MS Reference Sans Serif", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelforAdminHeading.ForeColor = Color.Red;
            labelforAdminHeading.Location = new Point(282, 21);
            labelforAdminHeading.Name = "labelforAdminHeading";
            labelforAdminHeading.Size = new Size(380, 35);
            labelforAdminHeading.TabIndex = 2;
            labelforAdminHeading.Text = "Shop Admin - Dashboard";
            // 
            // pictureBoxForLogoDashBoard
            // 
            pictureBoxForLogoDashBoard.BackColor = Color.Black;
            pictureBoxForLogoDashBoard.Image = (Image)resources.GetObject("pictureBoxForLogoDashBoard.Image");
            pictureBoxForLogoDashBoard.Location = new Point(0, -4);
            pictureBoxForLogoDashBoard.Name = "pictureBoxForLogoDashBoard";
            pictureBoxForLogoDashBoard.Size = new Size(94, 89);
            pictureBoxForLogoDashBoard.TabIndex = 0;
            pictureBoxForLogoDashBoard.TabStop = false;
            pictureBoxForLogoDashBoard.Click += pictureBox1_Click;
            // 
            // panelSideBar
            // 
            panelSideBar.Controls.Add(logoutButton);
            panelSideBar.Controls.Add(linkLabel2);
            panelSideBar.Controls.Add(pictureBoxForInventoryVector);
            panelSideBar.Controls.Add(linkLabelsToOrder);
            panelSideBar.Controls.Add(pictureBoxForOrderVector);
            panelSideBar.Location = new Point(2, 96);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(227, 402);
            panelSideBar.TabIndex = 1;
            // 
            // logoutButton
            // 
            logoutButton.ForeColor = Color.Red;
            logoutButton.Location = new Point(31, 319);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(159, 46);
            logoutButton.TabIndex = 6;
            logoutButton.Text = "LOGOUT";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.DisabledLinkColor = Color.White;
            linkLabel2.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Red;
            linkLabel2.Location = new Point(76, 213);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(132, 24);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "INVENTORY";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // pictureBoxForInventoryVector
            // 
            pictureBoxForInventoryVector.Image = (Image)resources.GetObject("pictureBoxForInventoryVector.Image");
            pictureBoxForInventoryVector.Location = new Point(5, 185);
            pictureBoxForInventoryVector.Name = "pictureBoxForInventoryVector";
            pictureBoxForInventoryVector.Size = new Size(65, 64);
            pictureBoxForInventoryVector.TabIndex = 2;
            pictureBoxForInventoryVector.TabStop = false;
            // 
            // linkLabelsToOrder
            // 
            linkLabelsToOrder.AutoSize = true;
            linkLabelsToOrder.DisabledLinkColor = Color.White;
            linkLabelsToOrder.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelsToOrder.LinkColor = Color.Red;
            linkLabelsToOrder.Location = new Point(76, 70);
            linkLabelsToOrder.Name = "linkLabelsToOrder";
            linkLabelsToOrder.Size = new Size(97, 24);
            linkLabelsToOrder.TabIndex = 1;
            linkLabelsToOrder.TabStop = true;
            linkLabelsToOrder.Text = "ORDERS";
            linkLabelsToOrder.LinkClicked += linkLabelsToOrder_LinkClicked;
            // 
            // pictureBoxForOrderVector
            // 
            pictureBoxForOrderVector.Image = (Image)resources.GetObject("pictureBoxForOrderVector.Image");
            pictureBoxForOrderVector.Location = new Point(0, 44);
            pictureBoxForOrderVector.Name = "pictureBoxForOrderVector";
            pictureBoxForOrderVector.Size = new Size(65, 50);
            pictureBoxForOrderVector.TabIndex = 0;
            pictureBoxForOrderVector.TabStop = false;
            // 
            // dataGridViewForRecentOrders
            // 
            dataGridViewForRecentOrders.BackgroundColor = Color.Black;
            dataGridViewForRecentOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewForRecentOrders.GridColor = SystemColors.InactiveCaptionText;
            dataGridViewForRecentOrders.Location = new Point(249, 203);
            dataGridViewForRecentOrders.Name = "dataGridViewForRecentOrders";
            dataGridViewForRecentOrders.Size = new Size(349, 258);
            dataGridViewForRecentOrders.TabIndex = 6;
            dataGridViewForRecentOrders.CellContentClick += dataGridViewForRecentOrders_CellContentClick;
            // 
            // button2
            // 
            button2.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(751, 108);
            button2.Name = "button2";
            button2.Size = new Size(101, 33);
            button2.TabIndex = 8;
            button2.Text = "Update Stock";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(249, 166);
            label1.Name = "label1";
            label1.Size = new Size(160, 16);
            label1.TabIndex = 9;
            label1.Text = "Recently Placed Orders";
            // 
            // dataGridViewStock
            // 
            dataGridViewStock.BackgroundColor = Color.Black;
            dataGridViewStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStock.GridColor = SystemColors.InactiveCaptionText;
            dataGridViewStock.Location = new Point(617, 203);
            dataGridViewStock.Name = "dataGridViewStock";
            dataGridViewStock.Size = new Size(235, 267);
            dataGridViewStock.TabIndex = 10;
            // 
            // addedProductsLabel
            // 
            addedProductsLabel.AutoSize = true;
            addedProductsLabel.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addedProductsLabel.ForeColor = Color.Red;
            addedProductsLabel.Location = new Point(617, 166);
            addedProductsLabel.Name = "addedProductsLabel";
            addedProductsLabel.Size = new Size(132, 16);
            addedProductsLabel.TabIndex = 11;
            addedProductsLabel.Text = "Stock In Inventory";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(883, 498);
            Controls.Add(addedProductsLabel);
            Controls.Add(dataGridViewStock);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(dataGridViewForRecentOrders);
            Controls.Add(panelSideBar);
            Controls.Add(panelNavBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panelNavBar.ResumeLayout(false);
            panelNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForLogoDashBoard).EndInit();
            panelSideBar.ResumeLayout(false);
            panelSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForInventoryVector).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForOrderVector).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForRecentOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelNavBar;
        private PictureBox pictureBoxForLogoDashBoard;
        private Panel panelSideBar;
        private PictureBox pictureBoxForOrderVector;
        private PictureBox pictureBoxForInventoryVector;
        private LinkLabel linkLabelsToOrder;
        private LinkLabel linkLabel2;
        private Button logoutButton;
        private Label labelforAdminHeading;
        private LinkLabel closeApplicationLinkLabel;
        private DataGridView dataGridViewForRecentProducts;
        private DataGridView dataGridViewForRecentOrders;
        private Button button2;
        private Label label1;
        private Label lb_addedProduct;
        private DataGridView dataGridViewStock;
        private Label addedProductsLabel;
    }
}