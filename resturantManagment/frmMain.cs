using System;
using System.Drawing;
using System.Windows.Forms;

namespace resturantManagment
{
    public partial class frmMain : Form
    {
        private Form currentForm = null;

        public frmMain()
        {
            InitializeComponent();
            ConnectButtonEvents();
        }

        private void ConnectButtonEvents()
        {   
            btnCategories.Click += btnCategories_Click;
            btnProducts.Click += btnProducts_Click;
            btnTables.Click += btnTables_Click;
            btnStaff.Click += btnStaff_Click;
            btnPOS.Click += btnPOS_Click;
            btnKitchen.Click += btnKitchen_Click;
            btnReports.Click += btnReports_Click;
            btnSettings.Click += btnSettings_Click;
            btnExit.Click += btnExit_Click;
            btnMinimize.Click += btnMinimize_Click;
            btnMaximize.Click += btnMaximize_Click;
        }

        private void OpenChildForm(Form childForm)
        {
            // Close current form if open
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Set new form properties
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Add to panelContainer
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;

            // Show the form
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            // Open category form in container
            OpenChildForm(new categoryfrm());

            // Update header title
            lblHeaderTitle.Text = "Category Management";

            // Update active button style (optional)
            SetActiveButton(btnCategories);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new productsForm());
            lblHeaderTitle.Text = "Product Management";
            SetActiveButton(btnProducts);
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Tables());
            lblHeaderTitle.Text = "Table Management";
            SetActiveButton(btnTables);
        }

        // Helper method to highlight active button
        private void SetActiveButton(Button activeButton)
        {
            // Reset all buttons to default color
            foreach (Control control in panelMenu.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;
                    btn.BackColor = Color.FromArgb(18, 36, 25);
                }
            }

            // Set active button color
            activeButton.BackColor = Color.FromArgb(38, 76, 55);
        }

        // Other button click events
        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff staffForm = new Staff();
            OpenChildForm(staffForm);
            // Add staff form later
            lblHeaderTitle.Text = "Staff Management";
            SetActiveButton(btnStaff);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            // Add POS form later
            lblHeaderTitle.Text = "POS Terminal";
            SetActiveButton(btnPOS);
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            // Add kitchen form later
            lblHeaderTitle.Text = "Kitchen Display";
            SetActiveButton(btnKitchen);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            // Add reports form later
            lblHeaderTitle.Text = "Reports";
            SetActiveButton(btnReports);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Add settings form later
            lblHeaderTitle.Text = "Settings";
            SetActiveButton(btnSettings);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
                // Or show login form: 
                // this.Hide();
                // new LoginForm().Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnStaff_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
