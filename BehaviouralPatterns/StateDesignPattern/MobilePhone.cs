using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class MobilePhone 
    {
        private IRingerState _currentState;

        public MobilePhone()
        {
            // Default state
            _currentState = new Ringing();
        }

        public void SetState(IRingerState state)
        {
            _currentState = state;
        }
        public void IncomingCall()
        {
            _currentState.HandleIncomingCall();
        }
    }
}
