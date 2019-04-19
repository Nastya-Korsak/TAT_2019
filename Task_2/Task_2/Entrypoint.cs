using System;
using System.Text;

namespace Task_2
{
    public class Entrypoint
    {
        /// <summary>
        /// Entry point. Calls all methods and display the result of the program
        /// </summary>
        /// <param name="args">Iputed array</param>
        static void Main(string[] args)
        {

            ErrorHandling h = new ErrorHandling();
            if (h.CheckEmptyString(args))
            {
               if(h.CheckStress(args))
                {
                    Word w = new Word();
                    StringBuilder outputLine = new StringBuilder();
                    outputLine=w.ChangeLetters(args);
                    Console.WriteLine(outputLine);
                }
            }
        }
    }
}
