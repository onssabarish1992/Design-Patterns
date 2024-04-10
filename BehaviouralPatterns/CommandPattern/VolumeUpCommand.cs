using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class VolumeUpCommand : ICommand
    {
        private Television _tv;

        public VolumeUpCommand(Television argTv)
        {
            _tv = argTv;
        }

        public void Execute()
        {
            _tv.VolumeUp();
        }
    }
}
