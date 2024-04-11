using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class Employee
    {
        public int EmpID { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeAddress{ get; set; }

        public abstract Employee GetEmployeeClone();

        public abstract void PrintEmployeeDetails();
    }
}
