using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_FINAL
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblMessage.Text = "All fields are required.";
                return;
            }

            try
            {
                var users = UserService.LoadUsers();

                var user = users.FirstOrDefault(u =>
                    u.Username == txtUsername.Text &&
                    u.Password == txtPassword.Text);

                if (user == null)
                {
                    lblMessage.Text = "Invalid username or password.";
                    return;
                }

                if (user.Role == "Admin")
                {
                    new AdminForm().Show();
                }
                else
                {
                    new CashierForm().Show();
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

    }
}
