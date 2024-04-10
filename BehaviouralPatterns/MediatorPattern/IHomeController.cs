using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    //Mediator
    public interface IHomeController
    {
        void Notify(Component sender, string eventInfo);
    }
}
