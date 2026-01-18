using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using resturantManagment.Models;
using resturantManagment.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace resturantManagment
{
    public partial class POS : Form
    {
        Cart cart = new Cart();
        BillingService billing = new BillingService();

        List<product> menu = new List<product>
        {
            new product { Id=1, Name="Burger", Price=250, ImagePath="Images/images.jfif", Category="Main" },
            new product { Id=2, Name="Pizza", Price=800, ImagePath="Images/images (1).jfif", Category = "Main" },
            new product { Id=3, Name="Pasta", Price=500, ImagePath="Images/download.jfif",Category="Main"},
            new product { Id=4, Name="Fries", Price=150, ImagePath="Images/54659021.avif", Category="Side" },
            new product { Id=5, Name="Ice cream",Price=200, ImagePath="Images/images (2).jfif", Category = "Side"},
            new product { Id=6, Name="Salad", Price=250, ImagePath="Images/images (3).jfif", Category= "Side"}
        };
        public POS()
        {
            InitializeComponent();
        }
        private void POS_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadMenu();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 94, 32);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI Semibold", 10);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 201);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.RowTemplate.Height = 90;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.Gainsboro;


        }
        void SetupGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.HeaderText = "Image";
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Add(img);

            dataGridView1.Columns.Add("Name", "Item");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Category", "Category");

            dataGridView1.Columns["Category"].Visible = false;
        }
        private void LoadMenu()
        {
            dataGridView1.Rows.Clear();

            foreach (var p in menu)
            {
                string fullPath = Path.Combine(Application.StartupPath, p.ImagePath);

                if (File.Exists(fullPath))
                {
                    Image img;
                    using (var bmpTemp = new Bitmap(fullPath))
                    {
                        img = new Bitmap(bmpTemp);
                    }

                    dataGridView1.Rows.Add(img, p.Name,"Rs " +p.Price,p.Category);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            cart.AddItem(menu[index], 1);

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = cart.Items;
            UpdateBill();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                CartItem item = (CartItem)dataGridView2.CurrentRow.DataBoundItem;
                cart.RemoveItem(item.Product.Id);

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = cart.Items;
                UpdateBill();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orders order = new Orders
            {
                OrderId = new Random().Next(1000, 9999),
                OrderDate = DateTime.Now,
                Items = cart.Items,
                TotalAmount = billing.CalculateTotal(cart.GetSubtotal())
            };

            new FileStorageService().SaveOrder(order);

            receipt rf = new receipt(GenerateReceipt(order));
            rf.ShowDialog();

            cart.Clear();
            dataGridView2.DataSource = null;
            UpdateBill();
        }
        private string GenerateReceipt(Orders order)
        {
            StringBuilder receipt = new StringBuilder();

            receipt.AppendLine("      RESTAURANT MANAGEMENT SYSTEM");
            receipt.AppendLine("--------------------------------------");
            receipt.AppendLine($"Order ID: {order.OrderId}");
            receipt.AppendLine($"Date: {order.OrderDate}");
            receipt.AppendLine("--------------------------------------");
            receipt.AppendLine("Item\tQty\tPrice");

            foreach (var item in order.Items)
            {
                receipt.AppendLine(
                    $"{item.Product.Name}\t{item.Quantity}\t{item.TotalPrice}"
                );
            }

            receipt.AppendLine("--------------------------------------");

            decimal subtotal = cart.GetSubtotal();

            receipt.AppendLine($"Subtotal: {subtotal}");
            receipt.AppendLine($"Tax: {billing.CalculateTax(subtotal)}");
            receipt.AppendLine($"Discount: {billing.CalculateDiscount(subtotal)}");
            receipt.AppendLine($"Total: {billing.CalculateTotal(subtotal)}");

            receipt.AppendLine("--------------------------------------");
            receipt.AppendLine("Thank you for your visit!");

            return receipt.ToString();
        }
        private void UpdateBill()
        {
            decimal subtotal = cart.GetSubtotal();
            label4.Text = subtotal.ToString();
            label5.Text = billing.CalculateTax(subtotal).ToString();
            label6.Text = billing.CalculateDiscount(subtotal).ToString();
            label7.Text = billing.CalculateTotal(subtotal).ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        void HighlightButton(System.Windows.Forms.Button active,System.Windows.Forms.Button inactive)
        {
            active.BackColor = Color.FromArgb(27, 94, 32);
            active.ForeColor = Color.White;

            inactive.BackColor = Color.LightGray;
            inactive.ForeColor = Color.Black;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = row.Cells["Category"].Value.ToString() == "Main";
            }

            HighlightButton(button4, button5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = row.Cells["Category"].Value.ToString() == "Side";
            }

            HighlightButton(button5, button4);
        }
       
    }
}
