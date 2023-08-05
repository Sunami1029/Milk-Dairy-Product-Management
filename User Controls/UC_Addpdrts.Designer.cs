namespace Milk_Dairy_Product_Management.User_Controls
{
    partial class UC_Addpdrts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Addpdrts));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            txtName1 = new TextBox();
            txtItemrate1 = new TextBox();
            txtCnname = new TextBox();
            txtCnnadress = new TextBox();
            txtCategory1 = new ComboBox();
            BTNreset = new LinkLabel();
            BtnSave1 = new Button();
            BtnBack1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 267);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(309, 60);
            label2.TabIndex = 1;
            label2.Text = "Add Products";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(316, 82);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(308, 123);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 3;
            label4.Text = "Item Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(33, 227);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 4;
            label5.Text = "Company Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(304, 165);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 6;
            label6.Text = "Item Rate";
            // 
            // txtName1
            // 
            txtName1.Location = new Point(429, 123);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(151, 27);
            txtName1.TabIndex = 7;
            // 
            // txtItemrate1
            // 
            txtItemrate1.Location = new Point(429, 165);
            txtItemrate1.Name = "txtItemrate1";
            txtItemrate1.Size = new Size(151, 27);
            txtItemrate1.TabIndex = 8;
            // 
            // txtCnname
            // 
            txtCnname.Location = new Point(173, 225);
            txtCnname.Name = "txtCnname";
            txtCnname.Size = new Size(139, 27);
            txtCnname.TabIndex = 9;
            // 
            // txtCnnadress
            // 
            txtCnnadress.Location = new Point(173, 265);
            txtCnnadress.Name = "txtCnnadress";
            txtCnnadress.Size = new Size(139, 27);
            txtCnnadress.TabIndex = 10;
            // 
            // txtCategory1
            // 
            txtCategory1.FormattingEnabled = true;
            txtCategory1.Items.AddRange(new object[] { "Milk", "Sweets", "Yagurt", "Paneer", "Cheese", "Butter", "Ghee" });
            txtCategory1.Location = new Point(429, 82);
            txtCategory1.Name = "txtCategory1";
            txtCategory1.Size = new Size(151, 28);
            txtCategory1.TabIndex = 11;
            // 
            // BTNreset
            // 
            BTNreset.AutoSize = true;
            BTNreset.BackColor = SystemColors.ActiveCaptionText;
            BTNreset.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BTNreset.ForeColor = Color.White;
            BTNreset.LinkColor = Color.Yellow;
            BTNreset.Location = new Point(429, 211);
            BTNreset.Name = "BTNreset";
            BTNreset.Size = new Size(88, 25);
            BTNreset.TabIndex = 12;
            BTNreset.TabStop = true;
            BTNreset.Text = "Reset All";
            BTNreset.LinkClicked += BTNreset_LinkClicked;
            // 
            // BtnSave1
            // 
            BtnSave1.BackColor = SystemColors.ActiveCaptionText;
            BtnSave1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSave1.ForeColor = Color.White;
            BtnSave1.Location = new Point(334, 247);
            BtnSave1.Name = "BtnSave1";
            BtnSave1.Size = new Size(94, 45);
            BtnSave1.TabIndex = 13;
            BtnSave1.Text = "Save";
            BtnSave1.UseVisualStyleBackColor = false;
            BtnSave1.Click += BtnSave1_Click;
            // 
            // BtnBack1
            // 
            BtnBack1.BackColor = SystemColors.ActiveCaptionText;
            BtnBack1.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBack1.ForeColor = Color.White;
            BtnBack1.Location = new Point(486, 247);
            BtnBack1.Name = "BtnBack1";
            BtnBack1.Size = new Size(94, 45);
            BtnBack1.TabIndex = 14;
            BtnBack1.Text = "Back";
            BtnBack1.UseVisualStyleBackColor = false;
            BtnBack1.Click += BtnBack1_Click;
            // 
            // UC_Addpdrts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(BtnBack1);
            Controls.Add(BtnSave1);
            Controls.Add(BTNreset);
            Controls.Add(txtCategory1);
            Controls.Add(txtCnnadress);
            Controls.Add(txtCnname);
            Controls.Add(txtItemrate1);
            Controls.Add(txtName1);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Addpdrts";
            Size = new Size(614, 384);
            Leave += UC_Addpdrts_Leave;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private TextBox txtName1;
        private TextBox txtItemrate1;
        private TextBox txtCnname;
        private TextBox txtCnnadress;
        private ComboBox txtCategory1;
        private LinkLabel BTNreset;
        private Button BtnSave1;
        private Button BtnBack1;
    }
}
