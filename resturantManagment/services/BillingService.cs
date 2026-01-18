using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturantManagment.Services
{
    public class BillingService
    {
        private const decimal TaxRate = 0.10m;

        public decimal CalculateTax(decimal subtotal)
        {
            return subtotal * TaxRate;
        }

        public decimal CalculateDiscount(decimal subtotal)
        {
            if (subtotal >= 1000)
                return subtotal * 0.05m;

            return 0;
        }

        public decimal CalculateTotal(decimal subtotal)
        {
            return subtotal + CalculateTax(subtotal) - CalculateDiscount(subtotal);
        }
    }
}
