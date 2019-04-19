using System;

namespace Task_2
{
    public class ErrorHandling
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
                if (args==null || args.Length == 0)
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
            int positionPlus = -1;
            int positionLetterE = -1;
            try
            {
                positionPlus=line.IndexOf("+");
                positionLetterE=line.IndexOf("ё");
                int numbeOfVowels = 0;
                for(int i = 0; i < line.Length; i++)
                {
                    if (line[i] == 'а' || line[i] == 'е' || line[i] == 'и' || line[i] == 'о' || line[i] == 'у' || line[i] == 'ы' || line[i] == 'э' || line[i] == 'ю' || line[i] == 'я')
                    {
                        numbeOfVowels++;
                    }
                }
                if((positionPlus==-1) && (positionLetterE == -1) && (numbeOfVowels!=1))
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
