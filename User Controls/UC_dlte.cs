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
    public partial class UC_dlte : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_dlte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            this.Hide();
            ds.Show();
        }
        public void loadData()
        {
            query = "select * from cusinfo";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_dlte_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from cusinfo where Iname like'" + textBssrch.Text + "%'";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete item?","Important Message",MessageBoxButtons.OKCancel ,MessageBoxIcon.Warning )== DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from cusinfo where iid= " + id + "";
                fn.setData(query);
                loadData();
            }
        }
    }
}
