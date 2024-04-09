using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    // State Interface
    public interface IRingerState
    {
        void HandleIncomingCall();
    }
}
