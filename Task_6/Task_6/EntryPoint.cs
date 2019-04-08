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
                WorkClass workClass = new WorkClass(args[0]);
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Error! You didn't put name XML-file");
            }
        }
    }
}
