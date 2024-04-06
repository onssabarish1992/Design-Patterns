using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //Observer Interface that is used to notify 
    public interface IJobSeeker
    {
        void Notify(Job argJob);
    }
}
