using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class ErrorHandling
    {
        /// <summary>
        /// This method chack that array isn't empty
        /// </summary>
        /// <param name="args">Iputed array</param>
        /// <returns>Return true if array isn't empty</returns>
        public bool CheckEmptyString(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    throw new FormatException();
                }
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! You didn't put string!");
                return false;
            }
        }
        /// <summary>
        /// This method chack that line have stress
        /// </summary>
        /// <param name="args">Iputed array</param>
        public bool CheckStress(string[] args)
        {
            string line = args[0];
            int a = -1;
            int b = -1;
            try
            {
                a=line.IndexOf("+");
                b=line.IndexOf("ё");
                int j = 0;
                for(int i = 0; i < line.Length; i++)
                {
                    if (line[i] == 'а' || line[i] == 'е' || line[i] == 'и' || line[i] == 'о' || line[i] == 'у' || line[i] == 'ы' || line[i] == 'э' || line[i] == 'ю' || line[i] == 'я')
                    {
                        j++;
                    }
                }
                if((a==-1) && (b == -1) && (j!=1))
                {
                    throw new FormatException();
                }
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! You didn't put the stress or your word don't have vowel letters!");
                return false;
            }
        }
    }
}
