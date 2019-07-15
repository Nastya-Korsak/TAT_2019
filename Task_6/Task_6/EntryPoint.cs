using System;

namespace Task_6
{
    /// <summary>
    /// Program for work with cars and xml-fail
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length==2)
                {
                    WorkClass workClass = new WorkClass(args[0], args[1]);
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Error! You didn't put name XML-file");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! You must put two XML-file");
            }
        }
    }
}
