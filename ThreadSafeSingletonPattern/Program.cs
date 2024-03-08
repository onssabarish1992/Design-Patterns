using ThreadSafeSingletonPattern;


Parallel.Invoke(
    () => PrintManagerDetails(),
    () => PrintEmployeeDetails()
    ) ;

void PrintManagerDetails()
{
    Console.WriteLine("Print Manager Details");
    SingletonThreadSafe fromManager = SingletonThreadSafe.GetInstance();
    fromManager.PrintDetails("Manager");
}


void PrintEmployeeDetails()
{
    Console.WriteLine("Print Employee Details");
    SingletonThreadSafe fromEmployee = SingletonThreadSafe.GetInstance();
    fromEmployee.PrintDetails("Employee");
}

Console.ReadKey();