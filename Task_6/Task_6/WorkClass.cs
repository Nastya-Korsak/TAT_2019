using System;
using System.Collections.Generic;

namespace Task_6
{
    /// <summary>
    /// Class for work with user
    /// </summary>
    class WorkClass
    {
        /// <summary>
        /// Constructor for defineds other object, and work with commands 
        /// </summary>
        /// <param name="nameXML">Name xml document</param>
        public WorkClass(string nameXML)
        {
            DataBase dataBase = new DataBase(@"D:\EPAM\Task_6\Task_6\" + nameXML);

            Dictionary<string, ICommand> listCommand = new Dictionary<string, ICommand>(4);
            listCommand.Add("count types", new CommandCountTypes(dataBase));
            listCommand.Add("count all", new CommandCountAll(dataBase));
            listCommand.Add("average price", new CommandAveragePrice(dataBase));
            listCommand.Add("average price type", new CommandAveragePriceType(dataBase));

            MotorShow motorShow = new MotorShow();

            bool exit = false;

            while (exit != true)
            {
                Console.WriteLine("Enter command: ");
                string command=Console.ReadLine();

                if (listCommand.ContainsKey(command))
                {
                    motorShow.SetCommand(listCommand[command]);
                    motorShow.GetInformation();
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
