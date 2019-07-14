using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class EntryPoint
    {
        /// <summary>
        /// Entry point this program. This program discribes educational disciplines.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Lecture lecture = new Lecture();
            List<Lecture> listLecture = new List<Lecture> {lecture };
            Discipline discipline = new Discipline(listLecture);
            Discipline cloneDiscipline =(Discipline) discipline.Clone();
            discipline[0].SetDescription("aaaaaa");
            if(discipline.Equals(discipline))
            Console.WriteLine("true");

            if (discipline.Equals(cloneDiscipline))
                Console.WriteLine("true");

            discipline.SetDescription("ooooo");
            Console.WriteLine(discipline[0].ToString());
            Console.WriteLine(cloneDiscipline[0].ToString());
            
        }
    }
}
