using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class BackEndCourse : ICourse
    {
        public void GetCourseName()
        {
            Console.WriteLine("Back end course");
        }

        public void GetCourseDuration()
        {
            Console.WriteLine("3 days");
        }
    }
}
