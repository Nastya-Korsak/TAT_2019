using System;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var adresses = JsonConvert.DeserializeObject<Adresses>(File.ReadAllText("Address.json"));

            string output = JsonConvert.SerializeObject(adresses);
            XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(output);

            int b = 10;
        }
    }
}
