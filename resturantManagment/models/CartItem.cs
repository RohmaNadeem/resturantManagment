using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resturantManagment.Models;

namespace resturantManagment.Models
{
    public class CartItem
    {
        public product Product { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPrice
        {
            get { return Product.Price * Quantity; }
        }
    }
}
