using System;
using System.Xml.Linq;

namespace Task_6
{
    /// <summary>
    ///Abstract Class Data Base defines data base Motor Show and have methods for work with that.
    /// </summary>
    abstract class DataBase
    {
        XDocument xDoc;
        /// <summary>
        /// Constructor for defining xml document and for verification this file.
        /// </summary>
        /// <param name="fileName">xml-file name</param>
        public DataBase(string fileName)
        {
            try
            {
                xDoc = XDocument.Load(fileName);
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
            int countType = 0;
            foreach (XElement carElement in xDoc.Element("cars").Elements("auto"))
            {
                Console.WriteLine(carElement.Element("brand").Value);
                countType++;
            }
                Console.WriteLine("Count type= " + countType);
        }

        /// <summary>
        /// Method for get count all cars. 
        /// </summary>
        public void GetCountAll()
        {
            int countAllAuto = 0;
            foreach (XElement carElement in xDoc.Element("cars").Elements("auto"))
            {
                countAllAuto += Int32.Parse(carElement.Element("count").Value); 
            }

            Console.WriteLine("Count all auto= " + countAllAuto);
        }

        /// <summary>
        /// Method for calculate average price.
        /// </summary>
        public void GetAveragePrice()
        {
            int averagePrice = 0;
            int countType = 0;

            foreach (XElement carElement in xDoc.Element("cars").Elements("auto"))
            {
                averagePrice += Int32.Parse(carElement.Element("price").Value);
                countType += 1;
            }

            Console.WriteLine("Average Price cars= " + averagePrice/ countType);
        }

        /// <summary>
        /// Method for calculate average price a certain type car.
        /// </summary>
        /// <param name="type">Type auto</param>
        public void GetAveragePriceType(string type)
        {
            int price=0;
            int count=0;

            foreach (XElement carElement in xDoc.Element("cars").Elements("auto"))
            {
                if (carElement.Element("brand").Value == type)
                {
                    count++;
                    price += Int32.Parse(carElement.Element("price").Value);
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
