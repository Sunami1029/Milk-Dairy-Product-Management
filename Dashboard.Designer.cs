namespace Milk_Dairy_Product_Management
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
            BtnExit1 = new Button();
            BttnSale = new Button();
            BtnAp = new Button();
            BtnUp = new Button();
            Btnrmp = new Button();
            panel1 = new Panel();
            uC_Wlc1 = new User_Controls.UC_Wlc();
            uC_orderww2 = new User_Controls.UC_orderww();
            panel2 = new Panel();
            uC_uPdete1 = new User_Controls.UC_UPdete();
            uC_Addpdrts1 = new User_Controls.UC_Addpdrts();
            pictureBox1 = new PictureBox();
            BtnLgout1 = new LinkLabel();
            uC_dlte1 = new User_Controls.UC_dlte();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnExit1
            // 
            BtnExit1.BackColor = Color.FromArgb(44, 45, 0);
            BtnExit1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnExit1.ForeColor = Color.White;
            BtnExit1.Location = new Point(-1, 0);
            BtnExit1.Name = "BtnExit1";
            BtnExit1.Size = new Size(50, 50);
            BtnExit1.TabIndex = 0;
            BtnExit1.Text = "X";
            BtnExit1.UseVisualStyleBackColor = false;
            BtnExit1.Click += BtnExit1_Click;
            // 
            // BttnSale
            // 
            BttnSale.BackColor = Color.FromArgb(44, 45, 0);
            BttnSale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BttnSale.ForeColor = Color.White;
            BttnSale.Location = new Point(12, 130);
            BttnSale.Name = "BttnSale";
            BttnSale.Size = new Size(180, 60);
            BttnSale.TabIndex = 1;
            BttnSale.Text = "Sales Information";
            BttnSale.UseVisualStyleBackColor = false;
            BttnSale.Click += BttnSale_Click;
            // 
            // BtnAp
            // 
            BtnAp.BackColor = Color.FromArgb(44, 45, 0);
            BtnAp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAp.ForeColor = Color.White;
            BtnAp.Location = new Point(12, 214);
            BtnAp.Name = "BtnAp";
            BtnAp.Size = new Size(180, 60);
            BtnAp.TabIndex = 2;
            BtnAp.Text = "Add Product";
            BtnAp.UseVisualStyleBackColor = false;
            BtnAp.Click += BtnAp_Click;
            // 
            // BtnUp
            // 
            BtnUp.BackColor = Color.FromArgb(44, 45, 0);
            BtnUp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUp.ForeColor = Color.White;
            BtnUp.Location = new Point(12, 297);
            BtnUp.Name = "BtnUp";
            BtnUp.Size = new Size(180, 60);
            BtnUp.TabIndex = 3;
            BtnUp.Text = "Update Product";
            BtnUp.UseVisualStyleBackColor = false;
            BtnUp.Click += BtnUp_Click;
            // 
            // Btnrmp
            // 
            Btnrmp.BackColor = Color.FromArgb(44, 45, 0);
            Btnrmp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Btnrmp.ForeColor = Color.White;
            Btnrmp.Location = new Point(12, 377);
            Btnrmp.Name = "Btnrmp";
            Btnrmp.Size = new Size(180, 60);
            Btnrmp.TabIndex = 4;
            Btnrmp.Text = "Remove Product";
            Btnrmp.UseVisualStyleBackColor = false;
            Btnrmp.Click += Btnrmp_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(uC_Wlc1);
            panel1.Location = new Point(214, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 100);
            panel1.TabIndex = 5;
            // 
            // uC_Wlc1
            // 
            uC_Wlc1.BackColor = SystemColors.ActiveCaptionText;
            uC_Wlc1.Location = new Point(0, -9);
            uC_Wlc1.Name = "uC_Wlc1";
            uC_Wlc1.Size = new Size(794, 109);
            uC_Wlc1.TabIndex = 0;
            // 
            // uC_orderww2
            // 
            uC_orderww2.BackColor = SystemColors.ActiveCaptionText;
            uC_orderww2.Location = new Point(16, 15);
            uC_orderww2.Name = "uC_orderww2";
            uC_orderww2.Size = new Size(728, 444);
            uC_orderww2.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(uC_dlte1);
            panel2.Controls.Add(uC_orderww2);
            panel2.Controls.Add(uC_uPdete1);
            panel2.Controls.Add(uC_Addpdrts1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(212, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 500);
            panel2.TabIndex = 6;
            // 
            // uC_uPdete1
            // 
            uC_uPdete1.BackColor = SystemColors.ActiveCaptionText;
            uC_uPdete1.Location = new Point(0, 6);
            uC_uPdete1.Name = "uC_uPdete1";
            uC_uPdete1.Size = new Size(856, 497);
            uC_uPdete1.TabIndex = 2;
            // 
            // uC_Addpdrts1
            // 
            uC_Addpdrts1.BackColor = SystemColors.ActiveCaptionText;
            uC_Addpdrts1.Location = new Point(3, 15);
            uC_Addpdrts1.Name = "uC_Addpdrts1";
            uC_Addpdrts1.Size = new Size(623, 328);
            uC_Addpdrts1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1000, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnLgout1
            // 
            BtnLgout1.AutoSize = true;
            BtnLgout1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLgout1.LinkColor = Color.White;
            BtnLgout1.Location = new Point(115, 512);
            BtnLgout1.Name = "BtnLgout1";
            BtnLgout1.Size = new Size(91, 31);
            BtnLgout1.TabIndex = 7;
            BtnLgout1.TabStop = true;
            BtnLgout1.Text = "Logout";
            BtnLgout1.LinkClicked += BtnLgout1_LinkClicked;
            // 
            // uC_dlte1
            // 
            uC_dlte1.BackColor = SystemColors.ActiveCaptionText;
            uC_dlte1.Location = new Point(7, 3);
            uC_dlte1.Name = "uC_dlte1";
            uC_dlte1.Size = new Size(827, 436);
            uC_dlte1.TabIndex = 4;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1298, 723);
            Controls.Add(BtnLgout1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Btnrmp);
            Controls.Add(BtnUp);
            Controls.Add(BtnAp);
            Controls.Add(BttnSale);
            Controls.Add(BtnExit1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnExit1;
        private Button BttnSale;
        private Button BtnAp;
        private Button BtnUp;
        private Button Btnrmp;
        private Panel panel1;
        private Panel panel2;
        private LinkLabel BtnLgout1;
        private PictureBox pictureBox1;
        private User_Controls.UC_Wlc uC_Wlc1;
        private User_Controls.UC_Addpdrts uC_Addpdrts1;
        private User_Controls.UC_orderww uC_orderww2;
        private User_Controls.UC_UPdete uC_uPdete1;
        private User_Controls.UC_dlte uC_dlte1;
    }
}