using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public abstract class Component
    {
        protected IHomeController _controller;

        public Component(IHomeController argController)
        {
            _controller = argController;
        }
    }
}
