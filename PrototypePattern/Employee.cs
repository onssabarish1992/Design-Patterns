using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal abstract class Employee
    {
        public string EmpName { get; set; }

        public int EmpAge { get; set; }

        public string EmpCity { get; set; }

        public abstract Employee CloneEmployee();

        public abstract void PrintEmployeeDetails();
    }
}
