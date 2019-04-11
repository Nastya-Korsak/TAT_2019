namespace Task_6
{
    /// <summary>
    /// This class defineds command for count types
    /// </summary>
    class CommandCountTypes : ICommand
    {
        DataBase dataBase;
        /// <summary>
        /// Constructor for identification Date Base for work
        /// </summary>
        /// <param name="dataBase">Date Base</param>
        public CommandCountTypes(DataBase dataBase)
        {
            this.dataBase = dataBase;
        }

        /// <summary>
        /// Method for getting count types
        /// </summary>
        public void Execute()
        {
            dataBase.GetCountType();
        }
    }
}
