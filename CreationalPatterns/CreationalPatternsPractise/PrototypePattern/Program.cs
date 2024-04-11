
using PrototypePattern;

Console.WriteLine("Prototype Pattern");

//Permanent Employee
Employee permanentEmployee1 = new PermanentEmployee()
{
    EmpID = 101,
    EmployeeName = "Sab",
    EmployeeAddress = "Dublin",
    Salary = 100,
};

Employee permEmployee2 = permanentEmployee1.GetEmployeeClone();

permEmployee2.EmpID = 101;
permEmployee2.EmployeeName = "Sid";
permEmployee2.PrintEmployeeDetails();

Console.ReadKey();
