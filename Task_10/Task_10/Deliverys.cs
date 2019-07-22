using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Task_10
{
    public class Deliverys
    {
      [JsonProperty("Deliverys")]
       public List<Delivery> ListDeliverys { get; set; }
    }

    public class Delivery
    {
        public int deliveryID { get; set; }
        public string description { get; set; }
        public int date { get; set; }
    }
}
