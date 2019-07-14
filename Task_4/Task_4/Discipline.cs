using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    /// <summary>
    /// Class Discipline
    /// </summary>
    class Discipline: ICloneable
    {
        private List<Lecture> lectures;
        protected Guid guid;
        private string description;
        int maxDescriptionLenght = 256;

        /// <summary>
        /// For create object withoout data
        /// </summary>
        public Discipline()
        {
            guid = Guid.NewGuid();
            description = "Discipline";
        }

        /// <summary>
        /// For create object with all data
        /// </summary>
        /// <param name="imputedLectures">List with Lectures</param>
        /// <param name="guid">GUID</param>
        /// <param name="description">Lecture description</param>
        public Discipline(List<Lecture> imputedLectures, Guid guid, string description)
        {
            if (imputedLectures != null)
            {
                lectures = new List<Lecture>();
                foreach (Lecture lecture in imputedLectures)
                {
                    lectures.Add((Lecture)lecture.Clone());
                }
            }

            this.guid = guid;
            this.description = description;
        }

        /// <summary>
        /// For create object only with Lecture list
        /// </summary>
        /// <param name="lectures">Lecture list</param>
        public Discipline(List<Lecture> lectures)
        {
            guid = Guid.NewGuid();
            description = "Discipline";
            this.lectures = lectures;
        }

        /// <summary>
        /// Indexator to receive a lecture on the index
        /// </summary>
        /// <param name="index">Inputed index</param>
        /// <returns>lecture</returns>
        public Lecture this [int index]
        {
            get { return lectures[index]; }
            set { lectures[index] = value; }
        }

        /// <summary>
        /// To add a description for Discipline
        /// </summary>
        /// <param name="text">Inputed description</param>
        public void SetDescription(string text)
        {
            try
            {
                if (text.Length <= maxDescriptionLenght)
                {
                    description = text;
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Text Lenght is more than "+ maxDescriptionLenght+"!");
            }
        }

        /// <summary>
        /// Overridden mhethod. Returns the description of the Discipline
        /// </summary>
        /// <returns>Description</returns>
        public override string ToString()
        {
            return description;
        }

        /// <summary>
        /// Method to return GUID this object
        /// </summary>
        /// <returns>GUID</returns>
        public Guid GuidDiscipline()
        {
            return this.guid;
        }

        /// <summary>
        /// Overridden mhethod. To compare the two object.
        /// </summary>
        /// <param name="obj">Compared object</param>
        /// <returns>Comparison result</returns>
        public override bool Equals(Object obj)
        {
            if (obj is Discipline)
            {
                Discipline disciplineObject = (Discipline)obj;
                return this.GuidDiscipline() == disciplineObject.GuidDiscipline() ? true : false;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Overridden mhethod. To clone object
        /// </summary>
        /// <returns>The cloned object</returns>
        public object Clone()
        {
            Discipline discipline = new Discipline(lectures, guid, description);
            return discipline;
        }
    }
}
