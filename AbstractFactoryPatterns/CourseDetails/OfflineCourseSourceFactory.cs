using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDetails
{
    //Concrete Factory 2
    internal class OfflineCourseSourceFactory : ICourseSourceFactory
    {
        public ICourse GetCourse()
        {
            return new BackendCourse();
        }

        public ISource GetSource()
        {
            return new Offline();
        }
    }
}
