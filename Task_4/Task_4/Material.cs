using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    /// <summary>
    /// Abstract class Material
    /// </summary>
    abstract class Material
    {
        protected Guid guid;
        protected string description;

        /// <summary>
        /// Sets the GUID when creating object
        /// </summary>
        public Material()
        {
            guid = Guid.NewGuid();
        }

        /// <summary>
        /// Method to return GUID this object
        /// </summary>
        /// <returns>GUID</returns>
        public Guid GetGuid()
        {
            return guid;
        }

        /// <summary>
        /// To add a description for object
        /// </summary>
        /// <param name="text">Inputed description</param>
        public void SetDescription(string text)
        {
            try
            {
                if (text.Length <= 256)
                {
                    description = text;
                }
                else
                {
                    throw new FormatException();
                }   
            }
            catch(FormatException)
            {
                Console.WriteLine("Error! Text Lenght is more than 256!");
            }
        }

        /// <summary>
        /// Overridden method. To compare the two object.
        /// </summary>
        /// <param name="obj">Compared object</param>
        /// <returns>Comparison result</returns>
        public override bool Equals(Object obj)
        {
            if (obj is Material)
            {
                Material disciplineObject = (Material)obj;
                return this.GetGuid() == disciplineObject.GetGuid() ? true : false;
            }
            else return false;
        }
    }
}
