namespace Milk_Dairy_Product_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            this.Hide();
            ds.Show();
        }

        private void Btnlgn_Click(object sender, EventArgs e)
        {
            if (txtUserN.Text == "Admin" && txtPaswrd.Text == "1234")
            {
                Dashboard ds = new Dashboard("Admin");
                this.Hide();
                ds.Show();
                MessageBox.Show("Login Successfull", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtUserN.Text != "Admin" && txtPaswrd.Text == "1234")
            {
                MessageBox.Show("invalid Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtUserN.Text == "Admin" && txtPaswrd.Text != "1234")
            {
                MessageBox.Show("invalid Paasword", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtUserN.Text != "Admin" && txtPaswrd.Text != "1234")
            {
                MessageBox.Show("invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
    }
}