namespace ont_design
{
    partial class Payment
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
            panel1 = new Panel();
            linkLabelToExitProduct = new LinkLabel();
            BillCustomer = new RadioButton();
            CreditCardBilling = new RadioButton();
            Billinglbl = new Label();
            label1 = new Label();
            CreditCardType = new ComboBox();
            label2 = new Label();
            CardNumber = new TextBox();
            label3 = new Label();
            ExpiryDate = new TextBox();
            PaymentSubmition = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(linkLabelToExitProduct);
            panel1.Controls.Add(BillCustomer);
            panel1.Controls.Add(CreditCardBilling);
            panel1.Controls.Add(Billinglbl);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 100);
            panel1.TabIndex = 0;
            // 
            // linkLabelToExitProduct
            // 
            linkLabelToExitProduct.AutoSize = true;
            linkLabelToExitProduct.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelToExitProduct.LinkColor = Color.Red;
            linkLabelToExitProduct.Location = new Point(637, 13);
            linkLabelToExitProduct.Name = "linkLabelToExitProduct";
            linkLabelToExitProduct.Size = new Size(50, 19);
            linkLabelToExitProduct.TabIndex = 5;
            linkLabelToExitProduct.TabStop = true;
            linkLabelToExitProduct.Text = "Close";
            linkLabelToExitProduct.LinkClicked += linkLabelToExitProduct_LinkClicked;
            // 
            // BillCustomer
            // 
            BillCustomer.AutoSize = true;
            BillCustomer.Font = new Font("Segoe UI", 11F);
            BillCustomer.ForeColor = Color.Red;
            BillCustomer.Location = new Point(412, 42);
            BillCustomer.Name = "BillCustomer";
            BillCustomer.Size = new Size(115, 24);
            BillCustomer.TabIndex = 4;
            BillCustomer.TabStop = true;
            BillCustomer.Text = "Bill Customer";
            BillCustomer.UseVisualStyleBackColor = true;
            // 
            // CreditCardBilling
            // 
            CreditCardBilling.AutoSize = true;
            CreditCardBilling.Font = new Font("Segoe UI", 11F);
            CreditCardBilling.ForeColor = Color.Red;
            CreditCardBilling.Location = new Point(36, 42);
            CreditCardBilling.Name = "CreditCardBilling";
            CreditCardBilling.Size = new Size(102, 24);
            CreditCardBilling.TabIndex = 3;
            CreditCardBilling.TabStop = true;
            CreditCardBilling.Text = "Credit Card";
            CreditCardBilling.UseVisualStyleBackColor = true;
            // 
            // Billinglbl
            // 
            Billinglbl.AutoSize = true;
            Billinglbl.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Billinglbl.ForeColor = Color.Red;
            Billinglbl.Location = new Point(23, -3);
            Billinglbl.Name = "Billinglbl";
            Billinglbl.Size = new Size(49, 19);
            Billinglbl.TabIndex = 2;
            Billinglbl.Text = "Billing";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(35, 165);
            label1.Name = "label1";
            label1.Size = new Size(141, 19);
            label1.TabIndex = 3;
            label1.Text = "Credit Card Type:";
            label1.Click += label1_Click;
            // 
            // CreditCardType
            // 
            CreditCardType.Font = new Font("Segoe UI", 11F);
            CreditCardType.FormattingEnabled = true;
            CreditCardType.Items.AddRange(new object[] { "Master Card", "Visa", "American Express" });
            CreditCardType.Location = new Point(207, 156);
            CreditCardType.Name = "CreditCardType";
            CreditCardType.Size = new Size(231, 28);
            CreditCardType.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(35, 219);
            label2.Name = "label2";
            label2.Size = new Size(115, 19);
            label2.TabIndex = 7;
            label2.Text = "Card Number:";
            // 
            // CardNumber
            // 
            CardNumber.Font = new Font("Segoe UI", 11F);
            CardNumber.Location = new Point(207, 211);
            CardNumber.Name = "CardNumber";
            CardNumber.PlaceholderText = "   2224526612000985";
            CardNumber.Size = new Size(192, 27);
            CardNumber.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(35, 270);
            label3.Name = "label3";
            label3.Size = new Size(129, 19);
            label3.TabIndex = 9;
            label3.Text = "Expiration Date:";
            // 
            // ExpiryDate
            // 
            ExpiryDate.Font = new Font("Segoe UI", 11F);
            ExpiryDate.Location = new Point(207, 266);
            ExpiryDate.Name = "ExpiryDate";
            ExpiryDate.PlaceholderText = "05/25";
            ExpiryDate.Size = new Size(79, 27);
            ExpiryDate.TabIndex = 10;
            // 
            // PaymentSubmition
            // 
            PaymentSubmition.BackColor = Color.FromArgb(64, 64, 64);
            PaymentSubmition.ForeColor = Color.Red;
            PaymentSubmition.Location = new Point(601, 372);
            PaymentSubmition.Name = "PaymentSubmition";
            PaymentSubmition.Size = new Size(98, 27);
            PaymentSubmition.TabIndex = 13;
            PaymentSubmition.Text = "Submit";
            PaymentSubmition.UseVisualStyleBackColor = false;
            PaymentSubmition.Click += PaymentSubmition_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(738, 450);
            Controls.Add(PaymentSubmition);
            Controls.Add(ExpiryDate);
            Controls.Add(label3);
            Controls.Add(CardNumber);
            Controls.Add(label2);
            Controls.Add(CreditCardType);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Billinglbl;
        private RadioButton BillCustomer;
        private RadioButton CreditCardBilling;
        private Label label1;
        private ComboBox CreditCardType;
        private Label label2;
        private TextBox CardNumber;
        private Label label3;
        private LinkLabel linkLabelToExitProduct;
        private TextBox ExpiryDate;
        private Button PaymentSubmition;
    }
}