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
    public partial class UC_UPdete : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_UPdete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            this.Hide();
            ds.Show();
        }

        private void txtxSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from cusinfo where Iname like'" + txtxSearch.Text + "%'";
            query = "select * from cusinfo";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_UPdete_Load(object sender, EventArgs e)
        {

            loadData();
        }
        public void loadData()
        {
            query = "select * from cusinfo";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            String Iname = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            int Irate = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());


            txtxcat.Text = category;
            txtxItemn.Text = Iname;
            txtxrate.Text = Irate.ToString();
        }

        private void BtnUpdateewe_Click(object sender, EventArgs e)
        {
            query = "Update Cusinfo set Iname='" + txtxItemn.Text + "',category='" + txtxcat.Text + "',Irate=" + txtxrate.Text + " where iid=" + id + "";
            fn.setData(query);
            loadData();

            txtxItemn.Clear();
            txtxcat.Clear();
            txtxrate.Clear();
        }
    }
}
