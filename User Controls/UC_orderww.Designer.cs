namespace Milk_Dairy_Product_Management.User_Controls
{
    partial class UC_orderww
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
            label6 = new Label();
            label7 = new Label();
            lblTtoal = new Label();
            listBox1 = new ListBox();
            BtnAccetSle = new Button();
            BtnRoma = new Button();
            BtnPrinnta = new Button();
            textBSearch = new TextBox();
            textBItname = new TextBox();
            textBTtl = new TextBox();
            textBuntRate = new TextBox();
            combotat = new ComboBox();
            txtxupndwn = new NumericUpDown();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)txtxupndwn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 46);
            label1.TabIndex = 0;
            label1.Text = "Sales&Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 55);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(472, 40);
            label3.Name = "label3";
            label3.Size = new Size(115, 23);
            label3.TabIndex = 2;
            label3.Text = "Rate Per Unit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(205, 39);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 3;
            label4.Text = "Item Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(205, 90);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(479, 90);
            label6.Name = "label6";
            label6.Size = new Size(49, 23);
            label6.TabIndex = 5;
            label6.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(439, 354);
            label7.Name = "label7";
            label7.Size = new Size(122, 28);
            label7.TabIndex = 6;
            label7.Text = "Grand Total";
            // 
            // lblTtoal
            // 
            lblTtoal.AutoSize = true;
            lblTtoal.BackColor = Color.White;
            lblTtoal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTtoal.ForeColor = Color.Black;
            lblTtoal.Location = new Point(472, 393);
            lblTtoal.Name = "lblTtoal";
            lblTtoal.Size = new Size(65, 28);
            lblTtoal.TabIndex = 7;
            lblTtoal.Text = "RS.00";
            lblTtoal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(15, 177);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(162, 244);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // BtnAccetSle
            // 
            BtnAccetSle.BackColor = SystemColors.ActiveCaptionText;
            BtnAccetSle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAccetSle.ForeColor = Color.White;
            BtnAccetSle.Location = new Point(566, 126);
            BtnAccetSle.Name = "BtnAccetSle";
            BtnAccetSle.Size = new Size(159, 45);
            BtnAccetSle.TabIndex = 9;
            BtnAccetSle.Text = "Accept Sale";
            BtnAccetSle.UseVisualStyleBackColor = false;
            BtnAccetSle.Click += BtnAccetSle_Click;
            // 
            // BtnRoma
            // 
            BtnRoma.BackColor = SystemColors.ActiveCaptionText;
            BtnRoma.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRoma.ForeColor = Color.White;
            BtnRoma.Location = new Point(307, 376);
            BtnRoma.Name = "BtnRoma";
            BtnRoma.Size = new Size(94, 45);
            BtnRoma.TabIndex = 10;
            BtnRoma.Text = "Remove";
            BtnRoma.UseVisualStyleBackColor = false;
            BtnRoma.Click += BtnRoma_Click;
            // 
            // BtnPrinnta
            // 
            BtnPrinnta.BackColor = SystemColors.ActiveCaptionText;
            BtnPrinnta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPrinnta.ForeColor = Color.White;
            BtnPrinnta.Location = new Point(583, 376);
            BtnPrinnta.Name = "BtnPrinnta";
            BtnPrinnta.Size = new Size(94, 45);
            BtnPrinnta.TabIndex = 11;
            BtnPrinnta.Text = "Print";
            BtnPrinnta.UseVisualStyleBackColor = false;
            BtnPrinnta.Click += BtnPrinnta_Click;
            // 
            // textBSearch
            // 
            textBSearch.Location = new Point(51, 144);
            textBSearch.Name = "textBSearch";
            textBSearch.PlaceholderText = "Search.Here...";
            textBSearch.Size = new Size(126, 27);
            textBSearch.TabIndex = 13;
            textBSearch.TextChanged += textBSearch_TextChanged;
            // 
            // textBItname
            // 
            textBItname.Location = new Point(324, 39);
            textBItname.Name = "textBItname";
            textBItname.Size = new Size(125, 27);
            textBItname.TabIndex = 14;
            // 
            // textBTtl
            // 
            textBTtl.Location = new Point(600, 81);
            textBTtl.Name = "textBTtl";
            textBTtl.Size = new Size(125, 27);
            textBTtl.TabIndex = 15;
            // 
            // textBuntRate
            // 
            textBuntRate.Location = new Point(600, 39);
            textBuntRate.Name = "textBuntRate";
            textBuntRate.Size = new Size(125, 27);
            textBuntRate.TabIndex = 16;
            // 
            // combotat
            // 
            combotat.FormattingEnabled = true;
            combotat.Items.AddRange(new object[] { "Milk", "Sweets", "Yagurt", "Paneer", "Cheese", "Butter", "Ghee" });
            combotat.Location = new Point(19, 81);
            combotat.Name = "combotat";
            combotat.Size = new Size(154, 28);
            combotat.TabIndex = 17;
            combotat.SelectedIndexChanged += combotat_SelectedIndexChanged;
            // 
            // txtxupndwn
            // 
            txtxupndwn.Location = new Point(324, 82);
            txtxupndwn.Name = "txtxupndwn";
            txtxupndwn.Size = new Size(124, 27);
            txtxupndwn.TabIndex = 18;
            txtxupndwn.ValueChanged += txtxupndwn_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(205, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(520, 174);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Item Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Unit Rate";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Total";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(704, 0);
            button1.Name = "button1";
            button1.Size = new Size(32, 29);
            button1.TabIndex = 20;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UC_orderww
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtxupndwn);
            Controls.Add(combotat);
            Controls.Add(textBuntRate);
            Controls.Add(textBTtl);
            Controls.Add(textBItname);
            Controls.Add(textBSearch);
            Controls.Add(BtnPrinnta);
            Controls.Add(BtnRoma);
            Controls.Add(BtnAccetSle);
            Controls.Add(listBox1);
            Controls.Add(lblTtoal);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_orderww";
            Size = new Size(739, 439);
            Leave += UC_orderww_Leave;
            ((System.ComponentModel.ISupportInitialize)txtxupndwn).EndInit();
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
        private Label label6;
        private Label label7;
        private Label lblTtoal;
        private ListBox listBox1;
        private Button BtnAccetSle;
        private Button BtnRoma;
        private Button BtnPrinnta;
        private TextBox textBSearch;
        private TextBox textBItname;
        private TextBox textBTtl;
        private TextBox textBuntRate;
        private ComboBox combotat;
        private NumericUpDown txtxupndwn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
    }
}
