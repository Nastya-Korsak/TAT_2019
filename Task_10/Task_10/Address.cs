using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Task_10
{
    public class Adresses
    {
        [JsonProperty("Adresses")]
        public List<Address> ListAdresses { get; set; }
    }

    public class Address
    {
        public int addressID { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int houseNumber { get; set; }
    }
}
