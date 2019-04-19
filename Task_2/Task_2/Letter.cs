namespace Task_2
{
    public class Letter
    {
        /// <summary>
        ///Checks letter for match with "и а у ы э" 
        /// </summary>
        /// <param name="letter">The letter of the word</param>
        /// /// <param name="pairedLetter">Return paired letter if validation is successful</param>
        /// <returns>Return 1 if validation is successful</returns>
        public int ChangeVowel_1(char letter, out char pairedLetter)
        {
            if (letter == 'а')
            {
                pairedLetter = 'а';
                return 1;
            }
            if (letter == 'у')
            {
                pairedLetter = 'у';
                return 1;
            }
            if ( letter == 'ы')
            {
                pairedLetter = 'ы';
                return 1;
            }
            if ( letter == 'э')
            {
                pairedLetter = 'э';
                return 1;
            }
            else
            {
                pairedLetter = letter;
                return 0;
            }
        }
        /// <summary>
        ///Checks letter for match with "е ё ю я"
        /// </summary>
        /// <param name="letter">The letter of the word</param>
        /// <param name="pairedLetter">Return paired letter if validation is successful</param>
        /// <returns>Return 2 if validation is successful</returns>
        public int ChangeVowel_2(char letter, out char pairedLetter)
        {
            if (letter == 'е')
            {
                pairedLetter = 'э';
                return 2;
            }
            if (letter == 'ё')
            {
                pairedLetter = 'о';
                return 2;
            }
            if (letter == 'ю')
            {
                pairedLetter = 'у';
                return 2;
            }
            if (letter == 'я')
            {
                pairedLetter = 'а';
                return 2;
            }
            if (letter == 'и')
            {
                pairedLetter = 'ы';
                return 2;
            }
            else
            {
                pairedLetter = letter;
                return 0;
            }
        }
        /// <summary>
        /// Checks letter for match with "б в г д ж з"
        /// </summary>
        /// <param name="letter">The letter of the word</param>
        /// <param name="pairedLetter">Return paired letter if validation is successful</param>
        /// <returns>Return 3 if validation is successful</returns>
        public int ChangeConsonant_1(char letter, out char pairedLetter)
        {
            if (letter == 'б')
            {
                pairedLetter = 'п';
                return 3;
            }
            if (letter == 'в')
            {
                pairedLetter = 'ф';
                return 30;
            }
            if (letter == 'г')
            {
                pairedLetter = 'к';
                return 3;
            }
            if (letter == 'д')
            {
                pairedLetter = 'т';
                return 3;
            }
            if (letter == 'ж')
            {
                pairedLetter = 'ш';
                return 3;
            }
            if (letter == 'з')
            {
                pairedLetter = 'с';
                return 3;
            }
            else
            {
                pairedLetter = letter;
                return 0;
            }
        }
        /// <summary>
        /// Checks letter for match with "п ф к т ш с х ц ч щ" 
        /// </summary>
        /// <param name="letter">The letter of the word</param>
        /// <param name="pairedLetter">Return paired letter if validation is successful</param>
        /// <returns>Return 4 if validation is successful</returns>
        public int ChangeConsonant_2(char letter, out char pairedLetter)
        {
            if (letter == 'п')
            {
                pairedLetter = 'б';
                return 4;
            }
            if (letter == 'ф')
            {
                pairedLetter = 'в';
                return 4;
            }
            if (letter == 'к')
            {
                pairedLetter = 'г';
                return 4;
            }
            if (letter == 'т')
            {
                pairedLetter = 'д';
                return 4;
            }
            if (letter == 'ш')
            {
                pairedLetter = 'ж';
                return 4;
            }
            if (letter == 'с')
            {
                pairedLetter = 'з';
                return 4;
            }
            if (letter == 'х')
            {
                pairedLetter = 'х';
                return 4;
            }
            if (letter == 'ц')
            {
                pairedLetter = 'ц';
                return 4;
            }
            if (letter == 'ч')
            {
                pairedLetter = 'ч';
                return 4;
            }
            if (letter == 'щ')
            {
                pairedLetter = 'щ';
                return 4;
            }
            else
            {
                pairedLetter = letter;
                return 0;
            }
        }
        /// <summary>
        /// Checks letter for match with "о ь ъ +"
        /// </summary>
        /// <param name="letter">The letter of the word</param>
        /// <param name="pairedLetter">Return paired letter if validation is successful</param>
        /// <returns>Return 5 or 6 if validation is successful</returns>
        public int OtherLetters(char letter, out char pairedLetter)
        {
            if (letter == 'о')
            {
                pairedLetter = 'а';
                return 5;
            }
            if (letter == 'ь')
            {
                pairedLetter = '`';
                return 6;
            }
            if (letter == 'ъ')
            {
                pairedLetter = 'ъ';
                return 6;
            }
            if (letter == '+')
            {
                pairedLetter = '+';
                return 6;
            }
            else
            {
                pairedLetter = letter;
                return 0;
            }
        }
    }
}
