using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// This class for change imputed string
    /// </summary>
    class Line
    {
        /// <summary>
        /// Data validation
        /// </summary>
        /// <param name="args">Input's array</param>
       public Line(string[] args)
        {
            try {
                if (args.Length == 0)
                {
                    throw new FormatException();
                }
                StringBuilder s = new StringBuilder();
                foreach (string el in args)
                {
                    s.AppendFormat(el);
                }
                if (s.Length < 2)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! You didn't write line or its lenght is smoller then 2");
            }
        }
        /// <summary>
        /// This metod makes searching substrings and displays it
        /// </summary>
        /// <param name="str">Input's string</param>
        public void SearchAndDisplay(string str)
        {
            string printed_line;

            for (int i = 0 ;i < str.Length; i++ )
            {
                printed_line = string.Empty;
                printed_line = printed_line + str[i];
                for (int j = 0; j < str.Length -i-1; j++)
                {
                    if (str[i+j] != str[i+1+j])
                    {
                        printed_line += str[i+1+j];
                       Console.WriteLine(printed_line);
                    }
                    else break;
                }
            }
        }

    }
}
