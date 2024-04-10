using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class TurnOnCommand : ICommand
    {
        private Television _tv;

        public TurnOnCommand(Television argTv)
        {
            _tv = argTv;
        }

        public void Execute()
        {
            _tv.TurnOn();
        }
    }
}
