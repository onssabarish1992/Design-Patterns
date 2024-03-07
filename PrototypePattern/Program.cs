


using PrototypePattern;

Console.WriteLine("Creating permanent Employees");
Employee permanentEmployee1 = new PermanentEmployee()
{
    EmpName = "Sabarish",
    EmpAge = 30,
    EmpCity = "Dublin",
    Salary = 40000
};


Employee permanentEmployee2 = permanentEmployee1.CloneEmployee();
permanentEmployee2.EmpName = "John";
permanentEmployee2.EmpAge = 42;

Console.WriteLine("Printing both the permanent employees");

permanentEmployee1.PrintEmployeeDetails();
permanentEmployee2.PrintEmployeeDetails();

Console.WriteLine("Creating temporary Employees");
Employee contractEmployee1 = new ContractEmployee()
{
    EmpName = "Vivek",
    EmpAge = 30,
    EmpCity = "Dublin",
    ContractRate = 70
};

Employee contractEmployee2 = contractEmployee1.CloneEmployee();
contractEmployee2.EmpName = "Rishabh";
contractEmployee2.EmpAge = 40;

Console.WriteLine("Printing both the contract employees");
contractEmployee1.PrintEmployeeDetails();
contractEmployee2.PrintEmployeeDetails();

Console.ReadKey();




