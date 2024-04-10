using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Window : Component
    {
        public Window(IHomeController argController) : base(argController)
        {
        }

        public void Open()
        {
            Console.WriteLine("Window Opened");
            _controller.Notify(this, "open");
        }
    }
}
