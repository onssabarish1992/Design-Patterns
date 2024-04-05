using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class ProxyImage : IImage
    {
        private RealImage? realImage = null;
        private string fileName { get; set; }

        public ProxyImage(string argFileName)
        {
            fileName = argFileName;
        }
        public void DisplayImage()
        {
            if(realImage == null)
            {
                realImage = new RealImage(fileName);
            }

            realImage.DisplayImage();
        }
    }
}
