using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    /// <summary>
    /// This class is Entrypoint for application. Contains method main.
    /// </summary>
    class Entrypoint
    {
        /// <summary>
        /// Entry point. Calls all methods and display the result of the program
        /// </summary>
        /// <param name="args">Iputed array</param>
        static void Main(string[] args)
        {
            ErrorHandling searchError = new ErrorHandling();
            if (searchError.CheckEmptyString(args))
            {
               if(searchError.CheckStress(args))
                {
                    Word changeWord = new Word();
                    StringBuilder outputLine = new StringBuilder();
                    outputLine=changeWord.ChangeLetters(args);
                    Console.WriteLine(outputLine);
                }
            }
        }
    }
}
