namespace Task_6
{
    /// <summary>
    /// This class defineds command for average price all cars
    /// </summary>
    class CommandAveragePrice:ICommand
    {
        DataBase dataBase;

        /// <summary>
        /// Constructor for identification Date Base for work
        /// </summary>
        /// <param name="dataBase">Date Base</param>
        public CommandAveragePrice(DataBase dataBase)
        {
            this.dataBase = dataBase;
        }

        /// <summary>
        /// Method for getting average price cars
        /// </summary>
        public void Execute()
        {
            dataBase.GetAveragePrice();
        }
    }
}
