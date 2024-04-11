using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class FrontEndCourse : ICourse
    {
        public void GetCourseName()
        {
            Console.WriteLine("Front end course");
        }

        public void GetCourseDuration()
        {
            Console.WriteLine("2 days");
        }
    }
}
