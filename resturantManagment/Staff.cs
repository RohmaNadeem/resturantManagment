using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace resturantManagment
{
    public partial class Staff : Form
    {
        SqlConnection con = new SqlConnection(
          @"Data Source=.\SQLEXPRESS;Initial Catalog=restranemtDB;Integrated Security=True");
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Waiter", "Chef", "Cashier", "Manager", "Cleaner" });
            comboBox2.Items.AddRange(new string[] { "Morning", "Evening", "Night" });
            comboBox3.Items.AddRange(new string[] { "Active", "Inactive" });

            LoadStaff();
        }
        void LoadStaff()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Staff", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox7.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "UPDATE Staff SET Name=@n,Phone=@p,CNIC=@c,Role=@r,Shift=@s,Salary=@sal,Status=@st WHERE StaffID=@id", con);

            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@n", textBox2.Text);
            cmd.Parameters.AddWithValue("@p", textBox3.Text);
            cmd.Parameters.AddWithValue("@c", textBox4.Text);
            cmd.Parameters.AddWithValue("@r", comboBox1.Text);
            cmd.Parameters.AddWithValue("@s", comboBox2.Text);
            cmd.Parameters.AddWithValue("@sal", textBox7.Text);
            cmd.Parameters.AddWithValue("@st", comboBox3.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Staff Updated");
            LoadStaff();
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Staff WHERE StaffID=@id", con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Staff Deleted");
            LoadStaff();
            Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(
              "SELECT * FROM Staff WHERE Name LIKE '%" + textBox5.Text + "%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Staff (Name,Phone,CNIC,Role,Shift,Salary,Status) VALUES (@n,@p,@c,@r,@s,@sal,@st)", con);

            cmd.Parameters.AddWithValue("@n", textBox2.Text);
            cmd.Parameters.AddWithValue("@p", textBox3.Text);
            cmd.Parameters.AddWithValue("@c", textBox4.Text);
            cmd.Parameters.AddWithValue("@r", comboBox1.Text);
            cmd.Parameters.AddWithValue("@s", comboBox2.Text);
            cmd.Parameters.AddWithValue("@sal", textBox7.Text);
            cmd.Parameters.AddWithValue("@st", comboBox3.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Staff Added");
            LoadStaff();
            Clear();
        }
    }
}
