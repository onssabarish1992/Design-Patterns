using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class ContractEmployee : Employee
    {
        public int ContractRate { get; set; }

        public override Employee CloneEmployee()
        {
            return (ContractEmployee)this.MemberwiseClone();
        }

        public override void PrintEmployeeDetails()
        {
            Console.WriteLine("Contract Employee: " + this.EmpName + this.EmpCity + this.EmpAge + this.ContractRate);
        }
    }
}
