using System;
using System.Collections.Generic;

namespace Task_4
{
    /// <summary>
    /// Lecture 
    /// </summary>
    class Lecture: Material
    {
        List<LaboratoryLesson> laboratorys;
        List<SeminaryLesson> seminary;
        Presentation presentation;
        private string lectureText;

        /// <summary>
        /// For create object withoout data
        /// </summary>
        public Lecture() : base()
        {
            laboratorys = null;
            seminary = null;
            description = "Lecture";
        }

        /// <summary>
        /// For create object with all data
        /// </summary>
        /// <param name="inputedLaboratory">List with Laboratory Lesson</param>
        /// <param name="ImputedSeminary">List with Seminary Lesson</param>
        /// <param name="presentation">Structur presentation</param>
        public Lecture(List<LaboratoryLesson> inputedLaboratory, List<SeminaryLesson> ImputedSeminary, Presentation presentation) : base()
        {
            if (inputedLaboratory != null)
            {
                laboratorys = new List<LaboratoryLesson>();
                foreach (LaboratoryLesson laboratory in inputedLaboratory)
                {
                    laboratorys.Add((LaboratoryLesson)laboratory.Clone());
                }
            }

            if (ImputedSeminary != null)
            {
                seminary = new List<SeminaryLesson>();
                foreach (SeminaryLesson seminar in ImputedSeminary)
                {
                    seminary.Add((SeminaryLesson)seminar.Clone());
                }
            }

            this.presentation = presentation;
            description = "Lecture";
        }

        /// <summary>
        /// This method for return and change Lecture text
        /// </summary>
        public string LectureText
        {
            get
            {
                if (lectureText != "")
                {
                    return lectureText;
                }
                else return "Lecture Text";
            }
            set
            {
                try
                {
                    if (value.Length <= 10000)
                    {
                        lectureText = value;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error! Text Lenght is more than 1000!");
                }
            }
        }

        /// <summary>
        /// Method for return lists with Laboratory Lesson and Seminary Lesson
        /// </summary>
        /// <returns>Tuple with lists with Laboratory Lesson and Seminary Lesson</returns>
        public (List<LaboratoryLesson>, List<SeminaryLesson>) ReturnData()
        {
            (List<LaboratoryLesson>, List<SeminaryLesson>) tuple = (laboratorys, seminary);
            return tuple;
        }

        /// <summary>
        /// Overridden method. Returns the description of the lecture
        /// </summary>
        /// <returns>Description</returns>
        public override string ToString()
        {
            return description;
        }

        /// <summary>
        /// Overridden method. To clone object
        /// </summary>
        /// <returns>The cloned object</returns>
        public object Clone()
        {
            Lecture lecturerr = new Lecture(laboratorys, seminary, presentation);
            return lecturerr;
        }
    }
}
