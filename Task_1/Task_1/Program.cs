using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0) { 
            int leng = args.Length;
            string s = null;
            foreach (string el in args)
            {
                s += el;
            }
            Line l = new Line();
            l.Search(s);
        }
        }
    }
}
