using SingletonPatternNotThreadSafe;

SingletonClass fromManager = SingletonClass.GetInstance();
fromManager.PrintDetails("Manager");


SingletonClass fromEmployee = SingletonClass.GetInstance();
fromManager.PrintDetails("Employee");

Console.ReadKey();