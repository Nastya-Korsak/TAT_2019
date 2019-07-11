using System;
using System.Text;


namespace Task_1
{
    /// <summary>
    /// This method is Entry point. Calling methods on the object Line for chenge string.
    /// </summary>
    class Entrypoint
    {
        static void Main(string[] args)
        {
            Line objLine = new Line(args);

            StringBuilder inputedString = new StringBuilder();
            foreach (string el in args)
            {
                inputedString.AppendFormat(el);
            }
            string line = inputedString.ToString();
            objLine.SearchAndDisplay(line);
        }
    }
}
