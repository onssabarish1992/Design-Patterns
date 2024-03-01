using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDetails
{
    internal class FrontEndCourse: ICourse
    {
        public string getCourseDuration()
        {
            return "6 months";
        }

        public int getCourseFees()
        {
            return 600;
        }

        public string getCourseName()
        {
            return "HTML";
        }
    }
}
