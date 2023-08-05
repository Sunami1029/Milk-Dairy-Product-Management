using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milk_Dairy_Product_Management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(String User)
        {
            InitializeComponent();
            if (User == "Guest")
            {
                BtnAp.Hide();
                Btnrmp.Hide();
                BtnUp.Hide();
            }
            else if (User == "Admin")
            {
                BtnAp.Show();
                Btnrmp.Show();
                BtnUp.Show();
            }
        }

        private void BtnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLgout1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Addpdrts1.Visible = false;
            uC_orderww2.Visible = false;
            uC_uPdete1.Visible = false;
            uC_Wlc1.Visible = true;
            uC_dlte1.Visible = false;
        }

        private void BtnAp_Click(object sender, EventArgs e)
        {
            uC_Wlc1.SendToBack();
            uC_Addpdrts1.Visible = true;
            uC_Addpdrts1.BringToFront();
        }

        private void BttnSale_Click(object sender, EventArgs e)
        {
            uC_Wlc1.SendToBack();
            uC_orderww2.Visible = true;
            uC_orderww2.BringToFront();
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            uC_uPdete1.Visible = true;
            uC_uPdete1.BringToFront();
        }

        private void Btnrmp_Click(object sender, EventArgs e)
        {
            uC_dlte1.Visible = true;
            uC_dlte1.BringToFront();

        }
    }
}
