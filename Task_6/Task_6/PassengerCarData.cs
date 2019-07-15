namespace Task_6
{
    /// <summary>
    /// Class PassengerCarData is for definition Passenger Cars. It uses Singleton pattern for protection object from re-creation
    /// </summary>
    class PassengerCarData : DataBase
    {
        /// <summary>
        /// Identification private object with type PassengerCarData
        /// </summary>
        private static PassengerCarData instance;

        /// <summary>
        /// Constructor with parameter. Invoke inherited class constructor
        /// </summary>
        /// <param name="fileName">xml-file name</param>
        protected PassengerCarData(string fileName) : base(fileName)
        {
        }

        /// <summary>
        /// Method for creates PassengerCarData class's object
        /// </summary>
        /// <param name="fileName">xml-file name</param>
        /// <returns>PassengerCarData class's object</returns>
        public static PassengerCarData GetInstance(string fileName)
        {
            if (instance == null)
                instance = new PassengerCarData(fileName);
            return instance;
        }
    }
}