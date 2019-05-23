using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Task_10
{
    /// <summary>
    /// This class is for manage essences
    /// </summary>
    public class Shop
    {
        Adresses addresses;
        Deliverys deliverys;
        Fabricators fabricators;
        Products products;
        WeareHouses weareHouses;

        public Shop(Adresses addresses, Deliverys deliverys, Fabricators fabricators, Products products, WeareHouses weareHouses)
        {
            this.addresses = addresses;
            this.deliverys = deliverys;
            this.fabricators = fabricators;
            this.products = products;
            this.weareHouses = weareHouses;
        }

        public void createXMLfiles()
        {
            XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode("Address.json");
        }

        public void CreateNewProduct()
        {
            Product product = new Product(18,"Kofe");
            products.ListProducts.Add(product);

            UpdateJsonFile();
        }

        public void UpdateJsonFile()
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(products, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(@"Address.json", output);
        }

        public void DeleteProduct(int id)
        {
            var product=products.ListProducts.Find(x => x.productID == id);
            products.ListProducts.Remove(product);

            UpdateJsonFile();
        }

    }
}
