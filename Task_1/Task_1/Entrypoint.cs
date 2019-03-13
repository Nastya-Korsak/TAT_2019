using System;
using System.Text;


namespace Task_1
{
    /// <summary>
    /// Entry point
    /// </summary>
    class Entrypoint
    {
        static void Main(string[] args)
        {
            Line l = new Line(args);

            StringBuilder s = new StringBuilder();
            foreach (string el in args)
            {
                s.AppendFormat(el);
            }
            string line = s.ToString();
            l.Search_and_Display(line);
        }
    }
}
