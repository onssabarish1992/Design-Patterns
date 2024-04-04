using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class FileItem : FileSystemItem
    {
        //The following Property is going to hold the size of the file
        public long FileBytes { get; }
        public FileItem(string name, long fileBytes) : base(name)
        {
            this.FileBytes = fileBytes;
        }

        public override decimal GetSizeinKB()
        {
            //Divide the size which will be in bytes with the value of 1024 to convert into KB
            return decimal.Divide(this.FileBytes, 1024);
        }
    }
}
