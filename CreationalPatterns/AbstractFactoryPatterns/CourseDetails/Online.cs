using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDetails
{
    internal class Online : ISource
    {
        public string getSourceName()
        {
            return "Online Course";
        }
    }
}
