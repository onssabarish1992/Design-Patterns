
using AbstractFactoryPattern;

Console.WriteLine("Abstract Factory Pattern");

//Offline course
ICourseSourceFactory coursesourceoffline = new OfflineCourseFactory();
coursesourceoffline.GetSource().GetSourceName();
coursesourceoffline.GetCourse().GetCourseName();


//Online course
ICourseSourceFactory coursesourceonline = new OfflineCourseFactory();
coursesourceonline.GetSource().GetSourceName();
coursesourceonline.GetCourse().GetCourseName();

Console.ReadKey();
