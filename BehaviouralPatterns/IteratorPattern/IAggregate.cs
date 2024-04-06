using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    //Aggregate Interface
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
