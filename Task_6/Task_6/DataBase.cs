using System;
using System.Collections.Generic;
using System.Xml;

namespace Task_6
{
    /// <summary>
    /// Class Data Base defines data base Motor Show and have methods for work with that.
    /// </summary>
    class DataBase
    {
        XmlDocument xDoc;
        /// <summary>
        /// Constructor for defining xml document and for verification this file.
        /// </summary>
        /// <param name="fileName">xml-file name</param>
        public DataBase(string fileName)
        {
            try
            {
                xDoc = new XmlDocument();
                xDoc.Load(fileName);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Your file didn't found!");
            }
        }

        /// <summary>
        /// Method for get count type cars
        /// </summary>
        public void GetCountType()
        {
            XmlElement xRoot = xDoc.DocumentElement;
            List<string> typs = new List<string>();

            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "brand")
                    {
                        if (!typs.Contains(childnode.InnerText))
                        {
                            typs.Add(childnode.InnerText);
                            Console.WriteLine(childnode.InnerText);
                        }                       
                    }
                }
            }
            Console.WriteLine("Count type= " + typs.Count);
        }

        /// <summary>
        /// Method for get count all cars. 
        /// </summary>
        public void GetCountAll()
        {
            XmlElement xRoot = xDoc.DocumentElement;
            int countAllAuto=0;

            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "count")
                    {
                        countAllAuto += Int32.Parse(childnode.InnerText);
                    }
                }
            }
            Console.WriteLine("Count all auto= " + countAllAuto);
        }

        /// <summary>
        /// Method for calculate average price.
        /// </summary>
        public void GetAveragePrice()
        {
            XmlElement xRoot = xDoc.DocumentElement;
            int averagePrice = 0;
            int countType = 0;

            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "price")
                    {
                        averagePrice += Int32.Parse(childnode.InnerText);
                        countType += 1;
                    }
                }
            }
            Console.WriteLine("Average Price cars= " + averagePrice/ countType);
        }

        /// <summary>
        /// Method for calculate average price a certain type car.
        /// </summary>
        /// <param name="type">Type auto</param>
        public void GetAveragePriceType(string type)
        {
            XmlElement xRoot = xDoc.DocumentElement;
            int price=0;
            int count=0;

            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "brand")
                    {
                        if (childnode.InnerText == type)
                        {
                            foreach (XmlNode childnode1 in xnode.ChildNodes)
                            {
                                if (childnode1.Name == "price")
                                {
                                    price += Int32.Parse(childnode1.InnerText);
                                    count += 1;
                                }
                            }

                        }
                    }
                }
            }
            try
            {
                if (count > 0)
                {
                    Console.WriteLine("Average Price " + type + " = " + price / count);
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Motor Show don't have this type auto.");
            }
        }
    }
}
