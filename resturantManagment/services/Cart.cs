using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resturantManagment.Models;

namespace resturantManagment.Services
{
    public class Cart
    {
        private List<CartItem> items = new List<CartItem>();

        public List<CartItem> Items => items;

        public void AddItem(product product, int quantity)
        {
            var item = items.FirstOrDefault(i => i.Product.Id == product.Id);

            if (item != null)
                item.Quantity += quantity;
            else
                items.Add(new CartItem { Product = product, Quantity = quantity });
        }

        public void RemoveItem(int productId)
        {
            items.RemoveAll(i => i.Product.Id == productId);
        }

        public decimal GetSubtotal()
        {
            return items.Sum(i => i.TotalPrice);
        }

        public void Clear()
        {
            items.Clear();
        }
    }
}
