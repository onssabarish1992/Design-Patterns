
using SingletonPattern;

Console.WriteLine("Singleton Pattern!");

Parallel.Invoke(
    () => PrintEmployeeDetails(),
    () => PrintCompanyDetails()
);


void PrintEmployeeDetails()
{
    Console.WriteLine("Employee Details");
    LogError error = LogError.GetInstance();
    error.LogApplicationError();
}

void PrintCompanyDetails()
{
    Console.WriteLine("Company Details");
    LogError error = LogError.GetInstance();
    error.LogApplicationError();
}

Console.ReadKey();
