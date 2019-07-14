namespace Task_6
{
    /// <summary>
    /// Class defines Motor Show. Invoker in pattern Comand.
    /// </summary>
    class MotorShow
    {
        ICommand command;

        /// <summary>
        /// Set command that will work for obtaining information
        /// </summary>
        /// <param name="command">Executable command</param>
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        /// <summary>
        /// Method for getting information
        /// </summary>
        public void GetInformation()
        {
            command.Execute();
        }

        /// <summary>
        /// Method for exit
        /// </summary>
        public void Leave()
        {
            //command.Leave();
        }
    }
}
