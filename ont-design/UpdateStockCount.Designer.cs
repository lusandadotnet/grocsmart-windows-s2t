namespace ont_design
{
    partial class UpdateStockCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStockCount));
            panelNavBar = new Panel();
            linkLabelToExitProduct = new LinkLabel();
            labelHeadingProduct = new Label();
            pictureBoxForLogoProductPage = new PictureBox();
            availableStockLabel = new Label();
            productNameLabel = new Label();
            productNameComboBox = new ComboBox();
            updatedStockTextBox = new TextBox();
            submitStockChangeBtn = new Button();
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
            panelNavBar.Location = new Point(0, -1);
            panelNavBar.Name = "panelNavBar";
            panelNavBar.Size = new Size(798, 86);
            panelNavBar.TabIndex = 1;
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
            labelHeadingProduct.Location = new Point(288, 35);
            labelHeadingProduct.Name = "labelHeadingProduct";
            labelHeadingProduct.Size = new Size(244, 24);
            labelHeadingProduct.TabIndex = 1;
            labelHeadingProduct.Text = "UPDATE STOCK LEVEL";
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
            // availableStockLabel
            // 
            availableStockLabel.AutoSize = true;
            availableStockLabel.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            availableStockLabel.ForeColor = Color.Red;
            availableStockLabel.Location = new Point(166, 255);
            availableStockLabel.Name = "availableStockLabel";
            availableStockLabel.Size = new Size(128, 19);
            availableStockLabel.TabIndex = 6;
            availableStockLabel.Text = "Stock Available:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productNameLabel.ForeColor = Color.Red;
            productNameLabel.Location = new Point(166, 168);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(122, 19);
            productNameLabel.TabIndex = 7;
            productNameLabel.Text = "Product Name:";
            // 
            // productNameComboBox
            // 
            productNameComboBox.FormattingEnabled = true;
            productNameComboBox.Location = new Point(374, 168);
            productNameComboBox.Name = "productNameComboBox";
            productNameComboBox.Size = new Size(158, 23);
            productNameComboBox.TabIndex = 8;
            // 
            // updatedStockTextBox
            // 
            updatedStockTextBox.Location = new Point(375, 251);
            updatedStockTextBox.Name = "updatedStockTextBox";
            updatedStockTextBox.Size = new Size(157, 23);
            updatedStockTextBox.TabIndex = 9;
            // 
            // submitStockChangeBtn
            // 
            submitStockChangeBtn.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitStockChangeBtn.ForeColor = Color.Red;
            submitStockChangeBtn.Location = new Point(375, 352);
            submitStockChangeBtn.Name = "submitStockChangeBtn";
            submitStockChangeBtn.Size = new Size(75, 23);
            submitStockChangeBtn.TabIndex = 10;
            submitStockChangeBtn.Text = "Update";
            submitStockChangeBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateStockCount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(submitStockChangeBtn);
            Controls.Add(updatedStockTextBox);
            Controls.Add(productNameComboBox);
            Controls.Add(productNameLabel);
            Controls.Add(availableStockLabel);
            Controls.Add(panelNavBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateStockCount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateStockCount";
            Load += UpdateStockCount_Load;
            panelNavBar.ResumeLayout(false);
            panelNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForLogoProductPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelNavBar;
        private LinkLabel linkLabelToExitProduct;
        private Label labelHeadingProduct;
        private PictureBox pictureBoxForLogoProductPage;
        private Label availableStockLabel;
        private Label productNameLabel;
        private ComboBox productNameComboBox;
        private TextBox updatedStockTextBox;
        private Button submitStockChangeBtn;
    }
}