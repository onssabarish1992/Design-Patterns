using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class PermanentEmployee : Employee
    {
        public int Salary { get; set; } // Permanent employee gets a fixed Salary

        public override Employee CloneEmployee()
        {
            return (PermanentEmployee)this.MemberwiseClone();
        }

        public override void PrintEmployeeDetails()
        {
            Console.WriteLine("Permanent Employee: " + this.EmpName + this.EmpCity + this.EmpAge + this.Salary);
        }
    }
}
