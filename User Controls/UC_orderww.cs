using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milk_Dairy_Product_Management.User_Controls
{
    public partial class UC_orderww : UserControl
    {
        Function fn = new Function();
        String query;


        public UC_orderww()
        {
            InitializeComponent();
        }

        private void combotat_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String category = combotat.Text;
            query = "select Iname from cusinfo where category='" + category + "'";
            showItemList(query);
        }

        private void textBSearch_TextChanged(object sender, EventArgs e)
        {


            String category = combotat.Text;
            query = "select Iname from cusinfo where category='" + category + "' and Iname like '" + textBSearch.Text + "%'";
            showItemList(query);

        }
        private void showItemList(String query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtxupndwn.ResetText();
            textBTtl.Clear();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            textBItname.Text = text;
            query = "select Irate from cusinfo where Iname='" + text + "'";
            DataSet ds = fn.GetData(query);
            try
            {
                textBuntRate.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
            }
        }

        private void txtxupndwn_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtxupndwn.Value.ToString());
            Int64 Total = Int64.Parse(textBuntRate.Text);
            textBTtl.Text = (quan * Total).ToString();
        }

        protected int n, total = 0;
        private void BtnAccetSle_Click(object sender, EventArgs e)
        {
            if (textBTtl.Text != "0" && textBTtl.Text != "")
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBItname.Text;
                dataGridView1.Rows[n].Cells[1].Value = textBuntRate.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtxupndwn.Value;
                dataGridView1.Rows[n].Cells[3].Value = textBTtl.Text;


                total += int.Parse(textBTtl.Text);
                lblTtoal.Text = "RS.  " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int amount;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }
        }

        private void BtnRoma_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            catch
            {

            }

            total -= amount;
            lblTtoal.Text = "RS.  " + total;
        }

        private void BtnPrinnta_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Customer Bill" + " " + "Of " + "Ricchi's Dairy";


            printer.SubTitle = String.Format("Date:{0}", DateTime.Now.ToLocalTime().ToString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PageText = String.Format("Welcome Again 🙏  ");

            printer.Footer = "Total Payable Amount :" + lblTtoal.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);


            total = 0;
            dataGridView1.Rows.Clear();
            lblTtoal.Text = "Rs.  " + total;



        }
        public void ClearAll()
        {
            textBItname.Clear();
            textBTtl.Clear();
            textBuntRate.Clear();

        }



        private void UC_orderww_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            this.Hide();
            ds.Show();
        }
    }
}


