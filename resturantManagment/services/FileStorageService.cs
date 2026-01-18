using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using resturantManagment.Models;

namespace resturantManagment.Services
{
    public class FileStorageService
    {
        private string filePath = "orders.json";

        public void SaveOrder(Orders order)
        {
            List<Orders> orders = new List<Orders>();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                orders = JsonConvert.DeserializeObject<List<Orders>>(json) ?? new List<Orders>();
            }

            orders.Add(order);

            string updatedJson = JsonConvert.SerializeObject(orders, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);
        }
    }
}
