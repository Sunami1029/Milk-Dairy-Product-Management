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
    public partial class UC_Addpdrts : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_Addpdrts()
        {
            InitializeComponent();
        }

        private void BTNreset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtCategory1.SelectedIndex = -1;
            txtCnnadress.Clear();
            txtCnname.Clear();
            txtName1.Clear();
            txtItemrate1.Clear();

        }

        private void BtnBack1_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            this.Hide();
            ds.Show();
        }

        private void BtnSave1_Click(object sender, EventArgs e)
        {
            query = "insert into cusinfo(Cname,Caddress,category,Iname,Irate) values('" + txtCnname.Text + "','" + txtCnnadress.Text + "','" + txtCategory1.Text + "','" + txtName1.Text + "','" + txtItemrate1.Text + "')";
            fn.setData(query);
            ClearAll();
        }
        public void ClearAll()
        {
            txtCategory1.SelectedIndex = -1;
            txtCnnadress.Clear();
            txtCnname.Clear();
            txtName1.Clear();
            txtItemrate1.Clear();

        }

        private void UC_Addpdrts_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
