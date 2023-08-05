namespace Milk_Dairy_Product_Management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            BtnGst = new LinkLabel();
            Btnlgn = new Button();
            pictureBox1 = new PictureBox();
            txtPaswrd = new TextBox();
            txtUserN = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 341);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 0;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 264);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // BtnGst
            // 
            BtnGst.AutoSize = true;
            BtnGst.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGst.LinkColor = Color.Yellow;
            BtnGst.Location = new Point(118, 498);
            BtnGst.Name = "BtnGst";
            BtnGst.Size = new Size(156, 23);
            BtnGst.TabIndex = 2;
            BtnGst.TabStop = true;
            BtnGst.Text = "Continue As Guest";
            BtnGst.LinkClicked += BtnGst_LinkClicked;
            // 
            // Btnlgn
            // 
            Btnlgn.BackColor = Color.FromArgb(44, 45, 0);
            Btnlgn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btnlgn.ForeColor = Color.White;
            Btnlgn.Location = new Point(118, 431);
            Btnlgn.Name = "Btnlgn";
            Btnlgn.Size = new Size(139, 41);
            Btnlgn.TabIndex = 3;
            Btnlgn.Text = "Login";
            Btnlgn.UseVisualStyleBackColor = false;
            Btnlgn.Click += Btnlgn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtPaswrd
            // 
            txtPaswrd.Location = new Point(38, 384);
            txtPaswrd.Name = "txtPaswrd";
            txtPaswrd.PasswordChar = '*';
            txtPaswrd.PlaceholderText = "Enter Your Password";
            txtPaswrd.Size = new Size(304, 27);
            txtPaswrd.TabIndex = 5;
            txtPaswrd.Text = "1234";
            // 
            // txtUserN
            // 
            txtUserN.Location = new Point(38, 299);
            txtUserN.Name = "txtUserN";
            txtUserN.PlaceholderText = "Enter Your User Name";
            txtUserN.Size = new Size(304, 27);
            txtUserN.TabIndex = 6;
            txtUserN.Text = "Admin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(371, 569);
            Controls.Add(txtUserN);
            Controls.Add(txtPaswrd);
            Controls.Add(pictureBox1);
            Controls.Add(Btnlgn);
            Controls.Add(BtnGst);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private LinkLabel BtnGst;
        private Button Btnlgn;
        private PictureBox pictureBox1;
        private TextBox txtPaswrd;
        private TextBox txtUserN;
    }
}