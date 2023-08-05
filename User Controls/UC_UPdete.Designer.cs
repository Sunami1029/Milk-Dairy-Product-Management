namespace Milk_Dairy_Product_Management.User_Controls
{
    partial class UC_UPdete
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            txtxSearch = new TextBox();
            txtxcat = new TextBox();
            txtxItemn = new TextBox();
            txtxrate = new TextBox();
            BtnUpdateewe = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 54);
            label1.TabIndex = 0;
            label1.Text = "Update Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(630, 41);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 1;
            label2.Text = "Item Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(533, 363);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(72, 371);
            label4.Name = "label4";
            label4.Size = new Size(98, 28);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(72, 417);
            label5.Name = "label5";
            label5.Size = new Size(117, 28);
            label5.TabIndex = 4;
            label5.Text = "Item Name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(821, 230);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtxSearch
            // 
            txtxSearch.Location = new Point(674, 72);
            txtxSearch.Name = "txtxSearch";
            txtxSearch.PlaceholderText = "Search...";
            txtxSearch.Size = new Size(125, 27);
            txtxSearch.TabIndex = 6;
            txtxSearch.TextChanged += txtxSearch_TextChanged;
            // 
            // txtxcat
            // 
            txtxcat.Location = new Point(210, 371);
            txtxcat.Name = "txtxcat";
            txtxcat.Size = new Size(125, 27);
            txtxcat.TabIndex = 7;
            // 
            // txtxItemn
            // 
            txtxItemn.Location = new Point(210, 417);
            txtxItemn.Name = "txtxItemn";
            txtxItemn.Size = new Size(125, 27);
            txtxItemn.TabIndex = 8;
            // 
            // txtxrate
            // 
            txtxrate.Location = new Point(638, 363);
            txtxrate.Name = "txtxrate";
            txtxrate.Size = new Size(125, 27);
            txtxrate.TabIndex = 9;
            // 
            // BtnUpdateewe
            // 
            BtnUpdateewe.BackColor = SystemColors.ActiveCaptionText;
            BtnUpdateewe.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUpdateewe.ForeColor = Color.White;
            BtnUpdateewe.Location = new Point(630, 411);
            BtnUpdateewe.Name = "BtnUpdateewe";
            BtnUpdateewe.Size = new Size(133, 45);
            BtnUpdateewe.TabIndex = 10;
            BtnUpdateewe.Text = "Update";
            BtnUpdateewe.UseVisualStyleBackColor = false;
            BtnUpdateewe.Click += BtnUpdateewe_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(816, 0);
            button1.Name = "button1";
            button1.Size = new Size(36, 31);
            button1.TabIndex = 11;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UC_UPdete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(button1);
            Controls.Add(BtnUpdateewe);
            Controls.Add(txtxrate);
            Controls.Add(txtxItemn);
            Controls.Add(txtxcat);
            Controls.Add(txtxSearch);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_UPdete";
            Size = new Size(852, 490);
            Load += UC_UPdete_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private TextBox txtxSearch;
        private TextBox txtxcat;
        private TextBox txtxItemn;
        private TextBox txtxrate;
        private Button BtnUpdateewe;
        private Button button1;
    }
}
