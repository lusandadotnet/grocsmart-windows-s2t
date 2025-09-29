namespace ont_design
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            panelNavBar = new Panel();
            linkLabelToExitProduct = new LinkLabel();
            labelHeadingProduct = new Label();
            pictureBoxForLogoProductPage = new PictureBox();
            productNameLabel = new Label();
            productNameTextBox = new TextBox();
            productPriceLabel = new Label();
            productPriceTextBox = new TextBox();
            availableStockTextBox = new TextBox();
            productTypeLabel = new Label();
            productTypeComboBox = new ComboBox();
            submitButtonProductPage = new Button();
            cancelButtonProductPage = new Button();
            label1 = new Label();
            label2 = new Label();
            dateTimeForExpD = new DateTimePicker();
            panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForLogoProductPage).BeginInit();
            SuspendLayout();
            // 
            // panelNavBar
            // 
            panelNavBar.BackColor = SystemColors.ActiveCaptionText;
            panelNavBar.Controls.Add(linkLabelToExitProduct);
            panelNavBar.Controls.Add(labelHeadingProduct);
            panelNavBar.Controls.Add(pictureBoxForLogoProductPage);
            panelNavBar.Location = new Point(1, 4);
            panelNavBar.Name = "panelNavBar";
            panelNavBar.Size = new Size(795, 84);
            panelNavBar.TabIndex = 0;
            // 
            // linkLabelToExitProduct
            // 
            linkLabelToExitProduct.AutoSize = true;
            linkLabelToExitProduct.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelToExitProduct.LinkColor = Color.Red;
            linkLabelToExitProduct.Location = new Point(742, 5);
            linkLabelToExitProduct.Name = "linkLabelToExitProduct";
            linkLabelToExitProduct.Size = new Size(50, 19);
            linkLabelToExitProduct.TabIndex = 2;
            linkLabelToExitProduct.TabStop = true;
            linkLabelToExitProduct.Text = "Close";
            linkLabelToExitProduct.LinkClicked += linkLabelToExitProduct_LinkClicked;
            // 
            // labelHeadingProduct
            // 
            labelHeadingProduct.AutoSize = true;
            labelHeadingProduct.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeadingProduct.ForeColor = Color.Red;
            labelHeadingProduct.ImageAlign = ContentAlignment.BottomCenter;
            labelHeadingProduct.Location = new Point(241, 26);
            labelHeadingProduct.Name = "labelHeadingProduct";
            labelHeadingProduct.Size = new Size(409, 24);
            labelHeadingProduct.TabIndex = 1;
            labelHeadingProduct.Text = "ADD A NEW PRODUCT TO INVENTORY";
            // 
            // pictureBoxForLogoProductPage
            // 
            pictureBoxForLogoProductPage.Image = (Image)resources.GetObject("pictureBoxForLogoProductPage.Image");
            pictureBoxForLogoProductPage.Location = new Point(0, 3);
            pictureBoxForLogoProductPage.Name = "pictureBoxForLogoProductPage";
            pictureBoxForLogoProductPage.Size = new Size(143, 75);
            pictureBoxForLogoProductPage.TabIndex = 0;
            pictureBoxForLogoProductPage.TabStop = false;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productNameLabel.ForeColor = Color.Red;
            productNameLabel.Location = new Point(145, 115);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(122, 19);
            productNameLabel.TabIndex = 1;
            productNameLabel.Text = "Product Name:";
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(318, 111);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(249, 23);
            productNameTextBox.TabIndex = 2;
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productPriceLabel.ForeColor = Color.Red;
            productPriceLabel.Location = new Point(146, 162);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new Size(113, 19);
            productPriceLabel.TabIndex = 3;
            productPriceLabel.Text = "Product Price:";
            productPriceLabel.Click += productPriceLabel_Click;
            // 
            // productPriceTextBox
            // 
            productPriceTextBox.Location = new Point(318, 158);
            productPriceTextBox.Name = "productPriceTextBox";
            productPriceTextBox.Size = new Size(249, 23);
            productPriceTextBox.TabIndex = 4;
            // 
            // availableStockTextBox
            // 
            availableStockTextBox.Location = new Point(318, 210);
            availableStockTextBox.Name = "availableStockTextBox";
            availableStockTextBox.Size = new Size(249, 23);
            availableStockTextBox.TabIndex = 6;
            // 
            // productTypeLabel
            // 
            productTypeLabel.AutoSize = true;
            productTypeLabel.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productTypeLabel.ForeColor = Color.Red;
            productTypeLabel.Location = new Point(145, 317);
            productTypeLabel.Name = "productTypeLabel";
            productTypeLabel.Size = new Size(147, 19);
            productTypeLabel.TabIndex = 7;
            productTypeLabel.Text = "Product Category:";
            // 
            // productTypeComboBox
            // 
            productTypeComboBox.FormattingEnabled = true;
            productTypeComboBox.Items.AddRange(new object[] { "Frozen", "Canned", "Shelf", "Drinks" });
            productTypeComboBox.Location = new Point(318, 313);
            productTypeComboBox.Name = "productTypeComboBox";
            productTypeComboBox.Size = new Size(249, 23);
            productTypeComboBox.TabIndex = 8;
            // 
            // submitButtonProductPage
            // 
            submitButtonProductPage.ForeColor = Color.Red;
            submitButtonProductPage.Location = new Point(639, 210);
            submitButtonProductPage.Name = "submitButtonProductPage";
            submitButtonProductPage.Size = new Size(98, 36);
            submitButtonProductPage.TabIndex = 9;
            submitButtonProductPage.Text = "Submit";
            submitButtonProductPage.UseVisualStyleBackColor = true;
            // 
            // cancelButtonProductPage
            // 
            cancelButtonProductPage.ForeColor = Color.Red;
            cancelButtonProductPage.Location = new Point(639, 300);
            cancelButtonProductPage.Name = "cancelButtonProductPage";
            cancelButtonProductPage.Size = new Size(98, 36);
            cancelButtonProductPage.TabIndex = 10;
            cancelButtonProductPage.Text = "Cancel";
            cancelButtonProductPage.UseVisualStyleBackColor = true;
            cancelButtonProductPage.Click += cancelButtonProductPage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(146, 214);
            label1.Name = "label1";
            label1.Size = new Size(128, 19);
            label1.TabIndex = 11;
            label1.Text = "Stock Available:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(145, 270);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 12;
            label2.Text = "Expiry Date:";
            // 
            // dateTimeForExpD
            // 
            dateTimeForExpD.Location = new Point(318, 266);
            dateTimeForExpD.Name = "dateTimeForExpD";
            dateTimeForExpD.Size = new Size(249, 23);
            dateTimeForExpD.TabIndex = 13;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 405);
            Controls.Add(dateTimeForExpD);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelButtonProductPage);
            Controls.Add(submitButtonProductPage);
            Controls.Add(productTypeComboBox);
            Controls.Add(productTypeLabel);
            Controls.Add(availableStockTextBox);
            Controls.Add(productPriceTextBox);
            Controls.Add(productPriceLabel);
            Controls.Add(productNameTextBox);
            Controls.Add(productNameLabel);
            Controls.Add(panelNavBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            panelNavBar.ResumeLayout(false);
            panelNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForLogoProductPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelNavBar;
        private Label labelHeadingProduct;
        private PictureBox pictureBoxForLogoProductPage;
        private Label productNameLabel;
        private TextBox productNameTextBox;
        private Label productPriceLabel;
        private TextBox productPriceTextBox;
        private TextBox availableStockTextBox;
        private LinkLabel linkLabelToExitProduct;
        private Label productTypeLabel;
        private ComboBox productTypeComboBox;
        private Button submitButtonProductPage;
        private Button cancelButtonProductPage;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimeForExpD;
    }
}