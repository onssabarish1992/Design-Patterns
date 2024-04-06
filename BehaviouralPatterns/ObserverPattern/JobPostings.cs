using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class JobPostings : IJobPostings
    {
        private List<IJobSeeker> _seekers=new List<IJobSeeker>();
        public void Attach(IJobSeeker argJobSeeker)
        {
            _seekers.Add(argJobSeeker);
        }

        public void Detach(IJobSeeker argJobSeeker)
        {
            _seekers.Remove(argJobSeeker);
        }

        public void Notify(Job argJob)
        {
            foreach (var item in _seekers)
            {
                item.Notify(argJob);
            }
        }

        public void AddJob(Job argJob)
        {
            Notify(argJob);
        }
    }
}
