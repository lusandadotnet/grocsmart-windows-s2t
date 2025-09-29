namespace ont_design
{
    partial class WholesaleDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WholesaleDash));
            panelNavBar = new Panel();
            closeApplicationLinkLabel = new LinkLabel();
            labelforAdminHeading = new Label();
            pictureBoxForLogoDashBoard = new PictureBox();
            dataGridViewAdminSales = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnDispatch = new Button();
            button2 = new Button();
            panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForLogoDashBoard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdminSales).BeginInit();
            SuspendLayout();
            // 
            // panelNavBar
            // 
            panelNavBar.BackColor = Color.Black;
            panelNavBar.Controls.Add(closeApplicationLinkLabel);
            panelNavBar.Controls.Add(labelforAdminHeading);
            panelNavBar.Controls.Add(pictureBoxForLogoDashBoard);
            panelNavBar.Location = new Point(-38, 1);
            panelNavBar.Name = "panelNavBar";
            panelNavBar.Size = new Size(759, 84);
            panelNavBar.TabIndex = 1;
            // 
            // closeApplicationLinkLabel
            // 
            closeApplicationLinkLabel.AutoSize = true;
            closeApplicationLinkLabel.DisabledLinkColor = Color.White;
            closeApplicationLinkLabel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeApplicationLinkLabel.LinkColor = Color.Red;
            closeApplicationLinkLabel.Location = new Point(690, 6);
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
            labelforAdminHeading.Location = new Point(185, 27);
            labelforAdminHeading.Name = "labelforAdminHeading";
            labelforAdminHeading.Size = new Size(467, 35);
            labelforAdminHeading.TabIndex = 2;
            labelforAdminHeading.Text = "Wholesaler Admin - Dashboard";
            // 
            // pictureBoxForLogoDashBoard
            // 
            pictureBoxForLogoDashBoard.BackColor = Color.Black;
            pictureBoxForLogoDashBoard.Image = (Image)resources.GetObject("pictureBoxForLogoDashBoard.Image");
            pictureBoxForLogoDashBoard.Location = new Point(38, -5);
            pictureBoxForLogoDashBoard.Name = "pictureBoxForLogoDashBoard";
            pictureBoxForLogoDashBoard.Size = new Size(94, 89);
            pictureBoxForLogoDashBoard.TabIndex = 0;
            pictureBoxForLogoDashBoard.TabStop = false;
            // 
            // dataGridViewAdminSales
            // 
            dataGridViewAdminSales.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewAdminSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdminSales.Location = new Point(119, 160);
            dataGridViewAdminSales.Name = "dataGridViewAdminSales";
            dataGridViewAdminSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAdminSales.Size = new Size(545, 272);
            dataGridViewAdminSales.TabIndex = 2;
            dataGridViewAdminSales.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(326, 110);
            label1.Name = "label1";
            label1.Size = new Size(138, 16);
            label1.TabIndex = 10;
            label1.Text = "ORDERS TO FULFIL:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 142);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 11;
            label2.Text = "label2";
            // 
            // btnDispatch
            // 
            btnDispatch.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDispatch.ForeColor = Color.Red;
            btnDispatch.Location = new Point(261, 455);
            btnDispatch.Name = "btnDispatch";
            btnDispatch.Size = new Size(138, 26);
            btnDispatch.TabIndex = 12;
            btnDispatch.Text = "Dispatch Order";
            btnDispatch.UseVisualStyleBackColor = true;
            btnDispatch.Click += btnDispatch_Click;
            // 
            // button2
            // 
            button2.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(405, 455);
            button2.Name = "button2";
            button2.Size = new Size(141, 26);
            button2.TabIndex = 13;
            button2.Text = "Mark as Delivered";
            button2.UseVisualStyleBackColor = true;
            // 
            // WholesaleDash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(734, 493);
            Controls.Add(button2);
            Controls.Add(btnDispatch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewAdminSales);
            Controls.Add(panelNavBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WholesaleDash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WholesaleDash";
            Load += WholesaleDash_Load;
            panelNavBar.ResumeLayout(false);
            panelNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForLogoDashBoard).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdminSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelNavBar;
        private LinkLabel closeApplicationLinkLabel;
        private Label labelforAdminHeading;
        private PictureBox pictureBoxForLogoDashBoard;
        private DataGridView dataGridViewAdminSales;
        private Label label1;
        private Label label2;
        private Button btnDispatch;
        private Button button2;
    }
}