using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class OnlineCourseFactory : ICourseSourceFactory
    {
        public ICourse GetCourse()
        {
            return new FrontEndCourse();
        }

        public ISource GetSource()
        {
            return new OnlineSource();
        }
    }
}
