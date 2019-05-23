using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Task_10
{
    public class Fabricators
    {
        [JsonProperty("Fabricators")]
        public List<Fabricator> ListFabricators { get; set; }
    }

    public class Fabricator
    {
        public int fabricatorID { get; set; }
        public string Name { get; set; }
        public string countri { get; set; }
        public int addressID { get; set; }
    }
}
