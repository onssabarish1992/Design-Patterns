using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDetails
{
    //Abstract Product A
    internal interface ICourse
    {
        string getCourseName();
        int getCourseFees();
        string getCourseDuration();
    }
}
