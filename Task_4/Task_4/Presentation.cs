//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Task_4
{
    /// <summary>
    /// Structur to describe the presentation
    /// </summary>
    struct Presentation
    {
        public string URI;
        private string format;

        /// <summary>
        /// For an establishment format
        /// </summary>
        public string Format
        {
            get { return format; }
            set
            {
                if(value=="Unknown" || value == "PPT" || value == "PDF")
                {
                    format = value;
                }
                else
                {
                    format = "Unknown";
                }
            }
        }
    }
}