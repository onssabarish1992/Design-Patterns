
using ObserverPattern;

Console.WriteLine("Observer Pattern");

JobPostings jobPostings = new JobPostings();

//Add subscribers to postings
jobPostings.Attach(new JobSeeker("Sabarish"));
jobPostings.Attach(new JobSeeker("Sabarish1"));
jobPostings.Attach(new JobSeeker("Sabarish2"));

//Post a new job
jobPostings.AddJob(new Job("Product Manager"));

Console.ReadKey();
