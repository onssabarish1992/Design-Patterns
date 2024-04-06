using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class JobSeeker : IJobSeeker
    {
        public string Name { get; set; }

        public JobSeeker(string argName)
        {
            Name = argName;
        }
        public void Notify(Job argJob)
        {
            Console.WriteLine($"Hi {Name}, new job posted with description: {argJob.Description}");
        }
    }
}
