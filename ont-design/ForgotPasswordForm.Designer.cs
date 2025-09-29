namespace ont_design
{
    partial class ForgotPasswordForm
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
            nameLb = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // nameLb
            // 
            nameLb.AutoSize = true;
            nameLb.BackColor = Color.Red;
            nameLb.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLb.ForeColor = Color.White;
            nameLb.Location = new Point(12, 25);
            nameLb.Name = "nameLb";
            nameLb.Size = new Size(238, 16);
            nameLb.TabIndex = 0;
            nameLb.Text = "Please enter your registered email:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("MS Reference Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(361, 58);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 2;
            button1.Text = "Get Password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(492, 122);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(nameLb);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLb;
        private TextBox textBox1;
        private Button button1;
    }
}