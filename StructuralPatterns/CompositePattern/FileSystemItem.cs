using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class FileSystemItem
    {
        public string Name { get; }

        public FileSystemItem(string name)
        {
            this.Name = name;
        }

        //The following method is going to be overridden in both Leaf and Composite class
        public abstract decimal GetSizeinKB();
    }
}
