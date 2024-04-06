using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //Subject Interface
    public interface IJobPostings
    {
        void Attach(IJobSeeker argJobSeeker);
        void Detach(IJobSeeker argJobSeeker);
        void Notify(Job argJob);
    }
}
