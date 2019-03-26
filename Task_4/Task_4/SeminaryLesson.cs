using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    /// <summary>
    /// Class Seminary Lesson
    /// </summary>
    class SeminaryLesson : Material
    {
        List<string> Task;
        Dictionary<string, string> QuestionAndAnswer;

        /// <summary>
        /// For create object
        /// </summary>
        public SeminaryLesson(): base()
        {
            Task = null;
            QuestionAndAnswer = null;
            description = "Seminary Lesson";
        }

        /// <summary>
        ///  For create object with all data
        /// </summary>
        /// <param name="Task">List Task</param>
        /// <param name="QuestionAndAnswer">Dictionary with Quastion and Answer</param>
        public SeminaryLesson(List<string> Task, Dictionary<string, string> QuestionAndAnswer) : base()
        {
            this.Task.AddRange(Task);
            this.QuestionAndAnswer = QuestionAndAnswer;
            description = "Seminary Lesson";
        }

        /// <summary>
        /// Overridden mhethod. Returns the description of the Seminary Lesson
        /// </summary>
        /// <returns>Description</returns>
        public override string ToString()
        {
            return description;
        }

        /// <summary>
        /// Overridden mhethod. To clone object
        /// </summary>
        /// <returns>The cloned object</returns>
        public object Clone()
        {
            SeminaryLesson seminaryLesson = new SeminaryLesson(Task, QuestionAndAnswer);
            return seminaryLesson;
        }
    }
}
