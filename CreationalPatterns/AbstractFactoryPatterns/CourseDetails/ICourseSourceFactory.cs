using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDetails
{
    //Abstract Factory
    internal interface ICourseSourceFactory
    {
        ICourse GetCourse();

        ISource GetSource();
    }
}
