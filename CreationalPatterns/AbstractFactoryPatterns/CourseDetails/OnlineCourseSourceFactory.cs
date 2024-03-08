using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDetails
{
    //Concrete Factory 1
    internal class OnlineCourseSourceFactory : ICourseSourceFactory
    {
        public ICourse GetCourse()
        {
            return new FrontEndCourse();
        }

        public ISource GetSource()
        {
            return new Online();
        }
    }
}
