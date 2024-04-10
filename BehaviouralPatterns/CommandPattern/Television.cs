using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    //Receiver - Television
    public class Television
    {
        public void TurnOn()
        {
            Console.WriteLine("TV On");
        }

        public void Turnff()
        {
            Console.WriteLine("TV Off");
        }

        public void VolumeUp()
        {
            Console.WriteLine("Volumne Up");
        }

        public void VolumeDown()
        {
            Console.WriteLine("Volumne Down");
        }
    }
}
