namespace ont_design
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            panelNavBarOrder = new Panel();
            linkToExitOrderPage = new LinkLabel();
            headingLabelOrderPage = new Label();
            logoPictureBoxOrderPage = new PictureBox();
            customerDetailsPanel = new Panel();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            Zip = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Province = new TextBox();
            City = new TextBox();
            label1 = new Label();
            StreetNo = new TextBox();
            comboBoxForGender = new ComboBox();
            labelForGender = new Label();
            labelforAddress = new Label();
            PhoneNumber = new TextBox();
            labelForPhoneNumber = new Label();
            textBoxForCustomerSurname = new TextBox();
            textboxtForCustomerName = new TextBox();
            labelNameAndSurname = new Label();
            labelCustomerDetails = new Label();
            panelForProductDetails = new Panel();
            checkoutBtn = new Button();
            labelCart = new Label();
            cartListBox = new ListBox();
            addToCartBtn = new Button();
            offredProductsListBox = new ListBox();
            numericUpDownForQauantity = new NumericUpDown();
            labelForQuantityOfOrder = new Label();
            labelForProductForOrder = new Label();
            dateTimePickerForOrderDate = new DateTimePicker();
            labelforDate = new Label();
            labelForProductDetailsHeading = new Label();
            panelNavBarOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBoxOrderPage).BeginInit();
            customerDetailsPanel.SuspendLayout();
            panelForProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownForQauantity).BeginInit();
            SuspendLayout();
            // 
            // panelNavBarOrder
            // 
            panelNavBarOrder.BackColor = SystemColors.ActiveCaptionText;
            panelNavBarOrder.Controls.Add(linkToExitOrderPage);
            panelNavBarOrder.Controls.Add(headingLabelOrderPage);
            panelNavBarOrder.Controls.Add(logoPictureBoxOrderPage);
            panelNavBarOrder.Location = new Point(1, 4);
            panelNavBarOrder.Name = "panelNavBarOrder";
            panelNavBarOrder.Size = new Size(878, 86);
            panelNavBarOrder.TabIndex = 0;
            // 
            // linkToExitOrderPage
            // 
            linkToExitOrderPage.AutoSize = true;
            linkToExitOrderPage.DisabledLinkColor = Color.White;
            linkToExitOrderPage.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkToExitOrderPage.LinkColor = Color.Red;
            linkToExitOrderPage.Location = new Point(819, 5);
            linkToExitOrderPage.Name = "linkToExitOrderPage";
            linkToExitOrderPage.Size = new Size(50, 19);
            linkToExitOrderPage.TabIndex = 2;
            linkToExitOrderPage.TabStop = true;
            linkToExitOrderPage.Text = "Close";
            linkToExitOrderPage.LinkClicked += linkToExitOrderPage_LinkClicked;
            // 
            // headingLabelOrderPage
            // 
            headingLabelOrderPage.AutoSize = true;
            headingLabelOrderPage.BackColor = SystemColors.ControlText;
            headingLabelOrderPage.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headingLabelOrderPage.ForeColor = Color.Red;
            headingLabelOrderPage.Location = new Point(398, 21);
            headingLabelOrderPage.Name = "headingLabelOrderPage";
            headingLabelOrderPage.Size = new Size(215, 24);
            headingLabelOrderPage.TabIndex = 1;
            headingLabelOrderPage.Text = "ADD A NEW ORDER";
            // 
            // logoPictureBoxOrderPage
            // 
            logoPictureBoxOrderPage.Image = (Image)resources.GetObject("logoPictureBoxOrderPage.Image");
            logoPictureBoxOrderPage.Location = new Point(0, -11);
            logoPictureBoxOrderPage.Name = "logoPictureBoxOrderPage";
            logoPictureBoxOrderPage.Size = new Size(156, 90);
            logoPictureBoxOrderPage.TabIndex = 0;
            logoPictureBoxOrderPage.TabStop = false;
            // 
            // customerDetailsPanel
            // 
            customerDetailsPanel.Controls.Add(textBox1);
            customerDetailsPanel.Controls.Add(label5);
            customerDetailsPanel.Controls.Add(label4);
            customerDetailsPanel.Controls.Add(Zip);
            customerDetailsPanel.Controls.Add(label3);
            customerDetailsPanel.Controls.Add(label2);
            customerDetailsPanel.Controls.Add(Province);
            customerDetailsPanel.Controls.Add(City);
            customerDetailsPanel.Controls.Add(label1);
            customerDetailsPanel.Controls.Add(StreetNo);
            customerDetailsPanel.Controls.Add(comboBoxForGender);
            customerDetailsPanel.Controls.Add(labelForGender);
            customerDetailsPanel.Controls.Add(labelforAddress);
            customerDetailsPanel.Controls.Add(PhoneNumber);
            customerDetailsPanel.Controls.Add(labelForPhoneNumber);
            customerDetailsPanel.Controls.Add(textBoxForCustomerSurname);
            customerDetailsPanel.Controls.Add(textboxtForCustomerName);
            customerDetailsPanel.Controls.Add(labelNameAndSurname);
            customerDetailsPanel.Controls.Add(labelCustomerDetails);
            customerDetailsPanel.Location = new Point(6, 96);
            customerDetailsPanel.Name = "customerDetailsPanel";
            customerDetailsPanel.Size = new Size(439, 523);
            customerDetailsPanel.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 172);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "example@gmail.com ";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(15, 172);
            label5.Name = "label5";
            label5.Size = new Size(55, 19);
            label5.TabIndex = 18;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(15, 280);
            label4.Name = "label4";
            label4.Size = new Size(75, 18);
            label4.TabIndex = 17;
            label4.Text = "Address";
            // 
            // Zip
            // 
            Zip.Location = new Point(148, 401);
            Zip.Name = "Zip";
            Zip.PlaceholderText = "6020";
            Zip.Size = new Size(41, 23);
            Zip.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(15, 405);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 15;
            label3.Text = "Zip:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(15, 377);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 14;
            label2.Text = "Province:";
            // 
            // Province
            // 
            Province.Location = new Point(148, 372);
            Province.Name = "Province";
            Province.PlaceholderText = "Eastern Cape";
            Province.Size = new Size(175, 23);
            Province.TabIndex = 13;
            // 
            // City
            // 
            City.Location = new Point(148, 343);
            City.Name = "City";
            City.PlaceholderText = "Port Elizabeth";
            City.Size = new Size(175, 23);
            City.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(15, 349);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 11;
            label1.Text = "City:";
            // 
            // StreetNo
            // 
            StreetNo.Location = new Point(148, 314);
            StreetNo.Name = "StreetNo";
            StreetNo.PlaceholderText = "163 marin Dr, Strand";
            StreetNo.Size = new Size(175, 23);
            StreetNo.TabIndex = 10;
            // 
            // comboBoxForGender
            // 
            comboBoxForGender.FormattingEnabled = true;
            comboBoxForGender.Location = new Point(148, 90);
            comboBoxForGender.Name = "comboBoxForGender";
            comboBoxForGender.Size = new Size(129, 23);
            comboBoxForGender.TabIndex = 9;
            // 
            // labelForGender
            // 
            labelForGender.AutoSize = true;
            labelForGender.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelForGender.ForeColor = Color.Red;
            labelForGender.Location = new Point(20, 98);
            labelForGender.Name = "labelForGender";
            labelForGender.Size = new Size(70, 19);
            labelForGender.TabIndex = 8;
            labelForGender.Text = "Gender:";
            // 
            // labelforAddress
            // 
            labelforAddress.AutoSize = true;
            labelforAddress.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelforAddress.ForeColor = Color.Red;
            labelforAddress.Location = new Point(15, 320);
            labelforAddress.Name = "labelforAddress";
            labelforAddress.Size = new Size(88, 19);
            labelforAddress.TabIndex = 6;
            labelforAddress.Text = "Street No:";
            labelforAddress.Click += labelforAddress_Click;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(148, 208);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.PlaceholderText = "+27 71 500 5801";
            PhoneNumber.Size = new Size(98, 23);
            PhoneNumber.TabIndex = 5;
            // 
            // labelForPhoneNumber
            // 
            labelForPhoneNumber.AutoSize = true;
            labelForPhoneNumber.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelForPhoneNumber.ForeColor = Color.Red;
            labelForPhoneNumber.Location = new Point(15, 212);
            labelForPhoneNumber.Name = "labelForPhoneNumber";
            labelForPhoneNumber.Size = new Size(62, 19);
            labelForPhoneNumber.TabIndex = 4;
            labelForPhoneNumber.Text = "Phone:";
            labelForPhoneNumber.Click += labelForPhoneNumber_Click;
            // 
            // textBoxForCustomerSurname
            // 
            textBoxForCustomerSurname.Location = new Point(283, 51);
            textBoxForCustomerSurname.Name = "textBoxForCustomerSurname";
            textBoxForCustomerSurname.PlaceholderText = "Doe";
            textBoxForCustomerSurname.Size = new Size(139, 23);
            textBoxForCustomerSurname.TabIndex = 3;
            // 
            // textboxtForCustomerName
            // 
            textboxtForCustomerName.Location = new Point(148, 51);
            textboxtForCustomerName.Name = "textboxtForCustomerName";
            textboxtForCustomerName.PlaceholderText = "John ";
            textboxtForCustomerName.Size = new Size(129, 23);
            textboxtForCustomerName.TabIndex = 2;
            // 
            // labelNameAndSurname
            // 
            labelNameAndSurname.AutoSize = true;
            labelNameAndSurname.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNameAndSurname.ForeColor = Color.Red;
            labelNameAndSurname.Location = new Point(15, 55);
            labelNameAndSurname.Name = "labelNameAndSurname";
            labelNameAndSurname.Size = new Size(97, 19);
            labelNameAndSurname.TabIndex = 1;
            labelNameAndSurname.Text = "Full Names:";
            // 
            // labelCustomerDetails
            // 
            labelCustomerDetails.AutoSize = true;
            labelCustomerDetails.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCustomerDetails.ForeColor = Color.Red;
            labelCustomerDetails.Location = new Point(164, 12);
            labelCustomerDetails.Name = "labelCustomerDetails";
            labelCustomerDetails.Size = new Size(137, 19);
            labelCustomerDetails.TabIndex = 0;
            labelCustomerDetails.Text = "Customer Details";
            // 
            // panelForProductDetails
            // 
            panelForProductDetails.Controls.Add(checkoutBtn);
            panelForProductDetails.Controls.Add(labelCart);
            panelForProductDetails.Controls.Add(cartListBox);
            panelForProductDetails.Controls.Add(addToCartBtn);
            panelForProductDetails.Controls.Add(offredProductsListBox);
            panelForProductDetails.Controls.Add(numericUpDownForQauantity);
            panelForProductDetails.Controls.Add(labelForQuantityOfOrder);
            panelForProductDetails.Controls.Add(labelForProductForOrder);
            panelForProductDetails.Controls.Add(dateTimePickerForOrderDate);
            panelForProductDetails.Controls.Add(labelforDate);
            panelForProductDetails.Controls.Add(labelForProductDetailsHeading);
            panelForProductDetails.Location = new Point(451, 96);
            panelForProductDetails.Name = "panelForProductDetails";
            panelForProductDetails.Size = new Size(428, 523);
            panelForProductDetails.TabIndex = 2;
            panelForProductDetails.Paint += panelForProductDetails_Paint;
            // 
            // checkoutBtn
            // 
            checkoutBtn.BackColor = Color.Green;
            checkoutBtn.ForeColor = SystemColors.ButtonHighlight;
            checkoutBtn.Location = new Point(204, 471);
            checkoutBtn.Name = "checkoutBtn";
            checkoutBtn.Size = new Size(75, 23);
            checkoutBtn.TabIndex = 14;
            checkoutBtn.Text = "Checkout";
            checkoutBtn.UseVisualStyleBackColor = false;
            checkoutBtn.Click += checkoutBtn_Click;
            // 
            // labelCart
            // 
            labelCart.AutoSize = true;
            labelCart.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCart.ForeColor = Color.Red;
            labelCart.Location = new Point(108, 331);
            labelCart.Name = "labelCart";
            labelCart.Size = new Size(87, 19);
            labelCart.TabIndex = 13;
            labelCart.Text = "Your Cart:";
            labelCart.Click += label6_Click;
            // 
            // cartListBox
            // 
            cartListBox.FormattingEnabled = true;
            cartListBox.ItemHeight = 15;
            cartListBox.Location = new Point(108, 372);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(281, 79);
            cartListBox.TabIndex = 12;
            // 
            // addToCartBtn
            // 
            addToCartBtn.ForeColor = Color.Red;
            addToCartBtn.Location = new Point(310, 239);
            addToCartBtn.Name = "addToCartBtn";
            addToCartBtn.Size = new Size(79, 34);
            addToCartBtn.TabIndex = 11;
            addToCartBtn.Text = "Add to cart";
            addToCartBtn.UseVisualStyleBackColor = true;
            addToCartBtn.Click += addToCartBtn_Click;
            // 
            // offredProductsListBox
            // 
            offredProductsListBox.BackColor = Color.Black;
            offredProductsListBox.ForeColor = SystemColors.Info;
            offredProductsListBox.FormattingEnabled = true;
            offredProductsListBox.ItemHeight = 15;
            offredProductsListBox.Location = new Point(108, 134);
            offredProductsListBox.Name = "offredProductsListBox";
            offredProductsListBox.Size = new Size(171, 139);
            offredProductsListBox.TabIndex = 10;
            offredProductsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // numericUpDownForQauantity
            // 
            numericUpDownForQauantity.Location = new Point(310, 194);
            numericUpDownForQauantity.Name = "numericUpDownForQauantity";
            numericUpDownForQauantity.Size = new Size(79, 23);
            numericUpDownForQauantity.TabIndex = 9;
            // 
            // labelForQuantityOfOrder
            // 
            labelForQuantityOfOrder.AutoSize = true;
            labelForQuantityOfOrder.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelForQuantityOfOrder.ForeColor = Color.Red;
            labelForQuantityOfOrder.Location = new Point(310, 134);
            labelForQuantityOfOrder.Name = "labelForQuantityOfOrder";
            labelForQuantityOfOrder.Size = new Size(79, 19);
            labelForQuantityOfOrder.TabIndex = 6;
            labelForQuantityOfOrder.Text = "Quantity:";
            // 
            // labelForProductForOrder
            // 
            labelForProductForOrder.AutoSize = true;
            labelForProductForOrder.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelForProductForOrder.ForeColor = Color.Red;
            labelForProductForOrder.Location = new Point(22, 134);
            labelForProductForOrder.Name = "labelForProductForOrder";
            labelForProductForOrder.Size = new Size(73, 19);
            labelForProductForOrder.TabIndex = 4;
            labelForProductForOrder.Text = "Product:";
            // 
            // dateTimePickerForOrderDate
            // 
            dateTimePickerForOrderDate.Location = new Point(108, 55);
            dateTimePickerForOrderDate.Name = "dateTimePickerForOrderDate";
            dateTimePickerForOrderDate.Size = new Size(208, 23);
            dateTimePickerForOrderDate.TabIndex = 3;
            // 
            // labelforDate
            // 
            labelforDate.AutoSize = true;
            labelforDate.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelforDate.ForeColor = Color.Red;
            labelforDate.Location = new Point(22, 55);
            labelforDate.Name = "labelforDate";
            labelforDate.Size = new Size(51, 19);
            labelforDate.TabIndex = 2;
            labelforDate.Text = "Date:";
            // 
            // labelForProductDetailsHeading
            // 
            labelForProductDetailsHeading.AutoSize = true;
            labelForProductDetailsHeading.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelForProductDetailsHeading.ForeColor = Color.Red;
            labelForProductDetailsHeading.Location = new Point(148, 12);
            labelForProductDetailsHeading.Name = "labelForProductDetailsHeading";
            labelForProductDetailsHeading.Size = new Size(120, 19);
            labelForProductDetailsHeading.TabIndex = 1;
            labelForProductDetailsHeading.Text = "Product Details";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(882, 622);
            Controls.Add(panelForProductDetails);
            Controls.Add(customerDetailsPanel);
            Controls.Add(panelNavBarOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelNavBarOrder.ResumeLayout(false);
            panelNavBarOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBoxOrderPage).EndInit();
            customerDetailsPanel.ResumeLayout(false);
            customerDetailsPanel.PerformLayout();
            panelForProductDetails.ResumeLayout(false);
            panelForProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownForQauantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavBarOrder;
        private PictureBox logoPictureBoxOrderPage;
        private Label headingLabelOrderPage;
        private LinkLabel linkToExitOrderPage;
        private Panel customerDetailsPanel;
        private Label labelforAddress;
        private TextBox PhoneNumber;
        private Label labelForPhoneNumber;
        private TextBox textBoxForCustomerSurname;
        private TextBox textboxtForCustomerName;
        private Label labelNameAndSurname;
        private Label labelCustomerDetails;
        private ComboBox comboBoxForGender;
        private Label labelForGender;
        private Panel panelForProductDetails;
        private Label labelForProductForOrder;
        private DateTimePicker dateTimePickerForOrderDate;
        private Label labelforDate;
        private Label labelForProductDetailsHeading;
        private Label labelForQuantityOfOrder;
        private NumericUpDown numericUpDownForQauantity;
        private Label label1;
        private TextBox StreetNo;
        private TextBox Province;
        private TextBox City;
        private TextBox Zip;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label labelCart;
        private ListBox cartListBox;
        private Button addToCartBtn;
        private Button checkoutBtn;
        private ListBox offredProductsListBox;
    }
}