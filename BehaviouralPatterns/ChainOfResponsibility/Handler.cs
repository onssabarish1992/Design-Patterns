using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    //Default Chaining Behaviour
    public abstract class Handler
    {
        //Holds reference to next handler
        public Handler NextHandler;

        public void SetNextHandler(Handler nextHandler)
        {
            NextHandler = nextHandler;
        }

        //This method will be implemented by child requests
        public abstract void DispatchNote(long requestedAmount);

    }
}
