using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using resturantManagment.Models;
using static resturantManagment.POS;

namespace resturantManagment
{
    public partial class Kitchen : Form
    {
        public Kitchen()
        {
            InitializeComponent();
        }

        private void Kitchen_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Order ID",
                DataPropertyName = "OrderId"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Type",
                DataPropertyName = "OrderType"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Status",
                DataPropertyName = "Status"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Time",
                DataPropertyName = "OrderDate"
            });
            dataGridView1.DataSource = OrderService.KitchenOrders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders order = (Orders)dataGridView1.CurrentRow.DataBoundItem;
            order.Status = "Preparing";
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orders order = (Orders)dataGridView1.CurrentRow.DataBoundItem;
            order.Status = "Ready";
            dataGridView1.Refresh();

        }
    }
}

