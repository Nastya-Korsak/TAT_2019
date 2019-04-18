using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Word
    {
        /// <summary>
        /// Changes inputed string on the sound type
        /// </summary>
        /// <param name="line">Iputed line</param>
        /// <returns>Sound type</returns>
        public StringBuilder ChangeLetters(string[] args)
        {
            StringBuilder outputLine = new StringBuilder();
            string line = args[0];
            char[] helpLine = new char[line.Length];
            int[] helpKod = new int[line.Length];
            Letter a = new Letter();
            //Assing each letter in string a code and a pair
            for(int i = 0; i < line.Length; i++)
            {
                helpKod[i]=a.ChangeConsonant_1(line[i],out helpLine[i]);
                if (helpKod[i] == 0)
                {
                    helpKod[i] = a.ChangeConsonant_2(line[i], out helpLine[i]);
                    if (helpKod[i] == 0)
                    {
                        helpKod[i] = a.ChangeVowel_1(line[i], out helpLine[i]);
                        if (helpKod[i] == 0)
                        {
                            helpKod[i] = a.ChangeVowel_2(line[i], out helpLine[i]);
                            if(helpKod[i] == 0)
                            {
                                helpKod[i] = a.OtherLetters(line[i], out helpLine[i]);
                            }
                        }
                    }
                }  
            }
            


            int n = 0;
            //Changing the first letter if it's vowle
            if (helpKod[0] == 2)
            {
                outputLine.AppendFormat("й" + helpLine[0].ToString());
                n = 1;
            }
            //Changing letters
            for (int i = n; i < line.Length - 1; i++)
            {
                //Working with "й л м н р"
                if (helpKod[i] == 0)
                {
                    outputLine.AppendFormat(helpLine[i].ToString());
                    continue;
                }
                //Working with "и а у ы э"
                if (helpKod[i] == 1)
                {
                    outputLine.AppendFormat(line[i].ToString());
                    continue;
                }
                //Working with "ъ ь +"
                if (helpKod[i] == 6)
                {
                    if (helpLine[i] == '`')
                    {
                        outputLine.AppendFormat(helpLine[i].ToString());
                        continue;
                    }
                    else { continue; }
                }
                //Working with "о"
                if (helpKod[i] == 5 && (helpLine[i + 1] == '+' || line.IndexOf("+") == -1))
                {
                    outputLine.AppendFormat("о");
                    continue;
                }
                else if (helpKod[i] == 5)
                {
                    outputLine.AppendFormat(helpLine[i].ToString());
                    continue;
                }
                //Working with transition "deaf sonorous-> sonorous sonorous" without "в"
                if (helpKod[i] == 4 && helpKod[i + 1] ==3 )
                {
                    outputLine.AppendFormat(helpLine[i].ToString());
                    continue;
                }else if(helpKod[i] == 4)
                {
                    outputLine.AppendFormat(line[i].ToString());
                }
                //Working with transition "sonorou deaf-> deaf deaf"
                if ((helpKod[i] == 3 || helpKod[i] == 30) && helpKod[i + 1] ==4)
                {
                    outputLine.AppendFormat(helpLine[i].ToString());
                    continue;
                }
                else if (helpKod[i] == 3 || helpKod[i] == 30)
                {
                    outputLine.AppendFormat(line[i].ToString());
                }
                //Working with "е ё ю я и" next to vowel and "ь Ъ"
                if (helpKod[i] == 2 && (helpKod[i - 1] == 6 || helpKod[i - 1] == 1 || helpKod[i - 1] == 5 || helpKod[i - 1] == 2) && helpLine[i - 1] != '+')
                {
                    outputLine.AppendFormat("й" + helpLine[i].ToString());
                    continue;
                }
                //Working with "е ё ю я и" next to consonant and "в"
                if (helpKod[i] == 2 && (helpKod[i - 1] == 3 || helpKod[i - 1] == 4 || helpKod[i - 1] == 30 || (helpKod[i-1]==0 && helpLine[i-1]!='й')))
                {
                    outputLine.AppendFormat("`" + helpLine[i].ToString());
                    continue;
                }
            }

            //Changing the last letter
            if (helpKod[line.Length-1] == 3 || helpKod[line.Length - 1] == 30)
            {
                outputLine.AppendFormat( helpLine[line.Length-1].ToString());
                return outputLine;
            }
            if (helpLine[line.Length-1] == '`' && (helpKod[line.Length - 2] == 3 || helpKod[line.Length - 2] == 30))
            {
                outputLine.Remove(outputLine.Length-1, 1);
                outputLine.AppendFormat(helpLine[line.Length-2].ToString()+ helpLine[line.Length-1].ToString());
                return outputLine;
            }
            else if (helpLine[line.Length - 1] == '`')
            {
                outputLine.AppendFormat(helpLine[line.Length - 1].ToString());
                return outputLine;
            }
            if (helpKod[line.Length - 1] == 0)
            {
                outputLine.AppendFormat(helpLine[line.Length - 1].ToString());
                return outputLine;
            }
            if (helpKod[line.Length - 1] == 1)
            {
                outputLine.AppendFormat(line[line.Length - 1].ToString());
                return outputLine;
            }
            if (helpKod[line.Length - 1] == 5)
            {
                outputLine.AppendFormat(helpLine[line.Length - 1].ToString());
                return outputLine;
            }
            if (helpKod[line.Length - 1] == 4)
            {
                outputLine.AppendFormat(line[line.Length - 1].ToString());
                return outputLine;
            }
            if (helpKod[line.Length - 1] == 3 || helpKod[line.Length - 1] == 30)
            {
                outputLine.AppendFormat(line[line.Length - 1].ToString());
                return outputLine;
            }
            if (helpKod[line.Length - 1] == 2 && (helpKod[line.Length - 2] == 6 || helpKod[line.Length - 2] == 1 || helpKod[line.Length - 2] == 5 || helpKod[line.Length - 2] == 2) && helpLine[line.Length - 2] != '+')
            {
                outputLine.AppendFormat("й" + helpLine[line.Length - 1].ToString());
                return outputLine;
            }
                if (helpKod[line.Length - 1] == 2 && (helpKod[line.Length - 2] == 3 || helpKod[line.Length - 2] == 4 || helpKod[line.Length - 2] == 30 || (helpKod[line.Length - 2] == 0 && helpLine[line.Length - 2] != 'й')))
            {
                outputLine.AppendFormat("`" + helpLine[line.Length - 1].ToString());
                    return outputLine;
                }
            else { return outputLine; }
        }
    }
}
