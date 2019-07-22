using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Task_10
{
    public class WeareHouses
    {
        [JsonProperty("Warehouses")]
        public List<WeareHouse> ListWarehouses { get; set; }
    }

    public class WeareHouse
    {
        public int warehouseID { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
    }
}
