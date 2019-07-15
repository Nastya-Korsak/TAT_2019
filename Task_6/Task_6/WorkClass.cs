using System;
using System.Collections.Generic;

namespace Task_6
{
    /// <summary>
    /// Class for work with user
    /// </summary>
    class WorkClass
    {
        delegate void Delegat();
        event Delegat Event;

        /// <summary>
        /// Constructor for defineds other object, and work with commands 
        /// </summary>
        /// <param name="carsXML">Name xml document</param>
        public WorkClass(string carsXML, string trucksXML)
        {
            DataBase passengerCarData = PassengerCarData.GetInstance(@"D:\EPAM\Task_6\Task_6\" + carsXML);
            DataBase lorryData = LorryData.GetInstance(@"D:\EPAM\Task_6\Task_6\" + carsXML);

            Dictionary<string, ICommand> listCommand = new Dictionary<string, ICommand>()
            {
                { "count types car", new CommandCountTypes(passengerCarData) },
                { "count all car", new CommandCountAll(passengerCarData ) },
                { "average price car", new CommandAveragePrice(passengerCarData) },
                { "average price car type", new CommandAveragePriceType(passengerCarData) },
                { "count types truck", new CommandCountTypes(lorryData) },
                { "count all truck", new CommandCountAll(lorryData) },
                { "average price truck", new CommandAveragePrice(lorryData) },
                { "average price truck type", new CommandAveragePriceType(lorryData) }
            };

            List < MotorShow > motorShowList = new List<MotorShow>();

            bool exit = false;

            while (exit != true)
            {
                Console.WriteLine("Enter command: ");
                string command=Console.ReadLine();

                if (listCommand.ContainsKey(command))
                {
                   motorShowList.Add(new MotorShow());
                   motorShowList[motorShowList.Count-1].SetCommand(listCommand[command]);
                   Event+= motorShowList[motorShowList.Count - 1].GetInformation;
                }
                else if (command=="execute")
                {
                    try
                    {
                        Event();
                        Event = null;
                    }
                    catch (System.NullReferenceException)
                    {
                        continue;
                    }
                }
                else if (command == "exit")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Your commad is not correct. Please input correct command.");
                }
            }
        }
    }
}
