using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Letter
    {
        /// <summary>
        ///Checks letter for match with "и а у ы э" 
        /// </summary>
        /// <param name="letter">The letter of the word</param>
        /// /// <param name="l">Return paired letter if validation is successful</param>
        /// <returns>Return 1 if validation is successful</returns>
        public int ChangeVowel1(char letter, out char l)
        {
            if (letter == 'а')
            {
                l = 'а';
                return 1;
            }
            if (letter == 'у')
            {
                l = 'у';
                return 1;
            }
            if ( letter == 'ы')
            {
                l = 'ы';
                return 1;
            }
            if ( letter == 'э')
            {
                l = 'э';
                return 1;
            }
            else
            {
                l = letter;
                return 0;
            }
        }
        /// <summary>
        ///Checks letter for match with "е ё ю я"
        /// </summary>
        /// <param name="letter">The letter of the word</param>
        /// <param name="l">Return paired letter if validation is successful</param>
        /// <returns>Return 2 if validation is successful</returns>
        public int ChangeVowel2(char letter, out char l)
        {
            if (letter == 'е')
            {
                l = 'э';
                return 2;
            }
            if (letter == 'ё')
            {
                l = 'о';
                return 2;
            }
            if (letter == 'ю')
            {
                l = 'у';
                return 2;
            }
            if (letter == 'я')
            {
                l = 'а';
                return 2;
            }
            if (letter == 'и')
            {
                l = 'ы';
                return 2;
            }
            else
            {
                l = letter;
                return 0;
            }
        }
        /// <summary>
        /// Checks letter for match with "б в г д ж з"
        /// </summary>
        /// <param name="letter">The letter of the word</param>
        /// <param name="l">Return paired letter if validation is successful</param>
        /// <returns>Return 3 if validation is successful</returns>
        public int ChangeConsonant1(char letter, out char l)
        {
            if (letter == 'б')
            {
                l = 'п';
                return 3;
            }
            if (letter == 'в')
            {
                l = 'ф';
                return 30;
            }
            if (letter == 'г')
            {
                l = 'к';
                return 3;
            }
            if (letter == 'д')
            {
                l = 'т';
                return 3;
            }
            if (letter == 'ж')
            {
                l = 'ш';
                return 3;
            }
            if (letter == 'з')
            {
                l = 'с';
                return 3;
            }
            else
            {
                l = letter;
                return 0;
            }
        }
        /// <summary>
        /// Checks letter for match with "п ф к т ш с х ц ч щ" 
        /// </summary>
        /// <param name="letter">The letter of the word</param>
        /// <param name="l">Return paired letter if validation is successful</param>
        /// <returns>Return 4 if validation is successful</returns>
        public int ChangeConsonant2(char letter, out char l)
        {
            if (letter == 'п')
            {
                l = 'б';
                return 4;
            }
            if (letter == 'ф')
            {
                l = 'в';
                return 4;
            }
            if (letter == 'к')
            {
                l = 'г';
                return 4;
            }
            if (letter == 'т')
            {
                l = 'д';
                return 4;
            }
            if (letter == 'ш')
            {
                l = 'ж';
                return 4;
            }
            if (letter == 'с')
            {
                l = 'з';
                return 4;
            }
            if (letter == 'х')
            {
                l = 'х';
                return 4;
            }
            if (letter == 'ц')
            {
                l = 'ц';
                return 4;
            }
            if (letter == 'ч')
            {
                l = 'ч';
                return 4;
            }
            if (letter == 'щ')
            {
                l = 'щ';
                return 4;
            }
            else
            {
                l = letter;
                return 0;
            }
        }
        /// <summary>
        /// Checks letter for match with "о ь ъ +"
        /// </summary>
        /// <param name="letter">The letter of the word</param>
        /// <param name="l">Return paired letter if validation is successful</param>
        /// <returns>Return 5 or 6 if validation is successful</returns>
        public int OtherLetters(char letter, out char l)
        {
            if (letter == 'о')
            {
                l = 'а';
                return 5;
            }
            if (letter == 'ь')
            {
                l = '`';
                return 6;
            }
            if (letter == 'ъ')
            {
                l = 'ъ';
                return 6;
            }
            if (letter == '+')
            {
                l = '+';
                return 6;
            }
            else
            {
                l = letter;
                return 0;
            }
        }
    }
}
