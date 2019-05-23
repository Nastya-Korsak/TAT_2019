using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Task_10
{
    public class Products
    {
        [JsonProperty("Products")]
        public List<Product> ListProducts { get; set; }
    }

    public class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
        public int fabricatorID { get; set; }
        public int warehouseID { get; set; }
        public int deliveryID { get; set; }
        public int productionDate { get; set; }

        public Product(int id, string name)
        {
            productID = id;
            productName = name;
        }
    }
}
