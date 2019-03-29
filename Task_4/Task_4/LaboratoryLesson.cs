using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    /// <summary>
    /// Class Laboratory Lesson
    /// </summary>
    class LaboratoryLesson : Material
    {

        public LaboratoryLesson(): base()
        {
            description = "Laboratory Lesson";
        }

        /// <summary>
        /// Overridden method. Returns the description of the Laboratory Lesson
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
            LaboratoryLesson laboratoryLesson = new LaboratoryLesson();
            return laboratoryLesson;
        }
    }
}
