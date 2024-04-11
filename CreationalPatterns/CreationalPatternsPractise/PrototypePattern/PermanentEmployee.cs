using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class PermanentEmployee: Employee
    {
        public int Salary { get; set; }

        public override Employee GetEmployeeClone()
        {
            return (Employee)this.MemberwiseClone();
        }

        public override void PrintEmployeeDetails()
        {
            Console.WriteLine("Permanent Employee");
            Console.WriteLine(this.EmpID+" "+this.EmployeeName+" "+this.EmployeeAddress+" "+this.Salary);
        }
    }
}
