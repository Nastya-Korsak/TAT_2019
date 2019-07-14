using System;

namespace Task_6
{
    /// <summary>
    /// This class defineds command for average price cars one type
    /// </summary>
    class CommandAveragePriceType: ICommand
    {
        DataBase dataBase;

        /// <summary>
        /// Constructor for identification Date Base for work
        /// </summary>
        /// <param name="dataBase">Date Base</param>
        public CommandAveragePriceType(DataBase dataBase)
        {
            this.dataBase = dataBase;
        }

        /// <summary>
        /// Method for getting average price cars one type
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("Please! Enter type of cars: ");
            dataBase.GetAveragePriceType(Console.ReadLine());
        }
    }
}
