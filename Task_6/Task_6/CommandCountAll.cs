namespace Task_6
{
    /// <summary>
    /// This class defineds command for count all cars
    /// </summary>
    class CommandCountAll : ICommand
    {
        DataBase dataBase;

        /// <summary>
        /// Constructor for identification Date Base for work
        /// </summary>
        /// <param name="dataBase">Date Base</param>
        public CommandCountAll(DataBase dataBase)
        {
            this.dataBase = dataBase;
        }

        /// <summary>
        /// Method for getting count all cars
        /// </summary>
        public void Execute()
        {
            dataBase.GetCountAll();
        }
    }
}
