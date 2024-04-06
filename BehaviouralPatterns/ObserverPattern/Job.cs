using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Job
    {
        public string Description { get; set; }

        public Job(string argDescription)
        {
            Description = argDescription;
        }
    }
}
