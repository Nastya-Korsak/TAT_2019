namespace Task_6
{
    /// <summary>
    /// Class LorryData is for definition Lorry Cars. It uses Singleton pattern for protection object from re-creation
    /// </summary>
    class LorryData : DataBase
    {
        /// <summary>
        /// Identification private object with type LorryData
        /// </summary>
        private static LorryData instance;

        /// <summary>
        /// Constructor with parameter. Invoke inherited class constructor
        /// </summary>
        /// <param name="fileName">xml-file name</param>
        protected LorryData(string fileName) : base(fileName)
        {
        }

        /// <summary>
        /// Method for creates LorryData class's object
        /// </summary>
        /// <param name="fileName">xml-file name</param>
        /// <returns>LorryData class's object</returns>
        public static LorryData GetInstance(string fileName)
        {
            if (instance == null)
                instance = new LorryData(fileName);
            return instance;
        }
    }
}