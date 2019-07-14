using System;

namespace Task_5
{
    /// <summary>
    /// Class determining object time of Flight
    /// </summary>
    class TimeOfFlight
    {
        /// <summary>
        /// Method for print time of flight object
        /// </summary>
        /// <param name="obj">Аlying object</param>
        /// <param name="time">Time of flight</param>
        public void Print(object obj ,double time)
        {
            if(obj is Bird || obj is Plane)
            {
                Console.WriteLine("Time is "+time.ToString()+" hours");
            }
            else
            {
                Console.WriteLine("Time is " + time.ToString() + " seconds");
            }
        }
    }
}
