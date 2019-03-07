using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Line
    {
        public void Search(string str)
        {
            string line = null;
            if (!Check(str)) return;

            for(int i = 0;i < str.Length; i++ )
            {
                line = "";
                line=line + str[i];
                for (int j = 0; j < str.Length -i-1; j++)
                {
                    if (str[i+j] != str[i+1+j])
                    {
                        line += str[i+1+j];
                       Console.WriteLine(line);
                    }
                    else break;
                }

            }
        }

         private static bool Check(string str)
        {
            return (str.Length >= 2) ? true : false;
        }

    }
}
