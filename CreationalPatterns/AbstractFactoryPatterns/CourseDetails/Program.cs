

using CourseDetails;
/*
* Online Course
*/

ICourseSourceFactory offlineFactory = new OfflineCourseSourceFactory();
//Get Course Details
var offlineCourse = offlineFactory.GetCourse();

Console.WriteLine("Offline Course Details");
Console.WriteLine(offlineCourse.getCourseName());
Console.WriteLine(offlineCourse.getCourseDuration());
Console.WriteLine(offlineCourse.getCourseFees());

//Get Source Details
var offlineSource = offlineFactory.GetSource();
Console.WriteLine(offlineSource.getSourceName());

/*
* Offline Course
*/

ICourseSourceFactory onlineFactory = new OnlineCourseSourceFactory();
//Get Course Details
var onlineCourse = onlineFactory.GetCourse();

Console.WriteLine("Online Course Details");
Console.WriteLine(onlineCourse.getCourseName());
Console.WriteLine(onlineCourse.getCourseDuration());
Console.WriteLine(onlineCourse.getCourseFees());

//Get Source Details
var onlineSourse = onlineFactory.GetSource();
Console.WriteLine(onlineSourse.getSourceName());


Console.ReadKey();

