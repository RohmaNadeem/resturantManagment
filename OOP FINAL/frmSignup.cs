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
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                cmbRole.SelectedIndex == -1)
            {
                lblMessage.Text = "All fields are required.";
                return;
            }

            var users = UserService.LoadUsers();

            if (users.Any(u => u.Username == txtUsername.Text))
            {
                lblMessage.Text = "Username already exists.";
                return;
            }

            users.Add(new User
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = cmbRole.SelectedItem.ToString()
            });

            UserService.SaveUsers(users);

            MessageBox.Show("Account created successfully!");
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
