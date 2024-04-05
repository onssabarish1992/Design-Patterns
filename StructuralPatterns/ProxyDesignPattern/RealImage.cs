using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class RealImage : IImage
    {
        private string FileName { get; set; }

        public RealImage(string argFileName)
        {
            FileName = argFileName;
        }

        public void LoadImageFromDisk()
        {
            Console.WriteLine("Loading Image from disk:" + " " + FileName);
        }

        public void DisplayImage()
        {
            Console.WriteLine("Displaying Image:" + " "+ FileName);
        }
    }
}
