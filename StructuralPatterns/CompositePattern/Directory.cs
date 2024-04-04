using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Directory: FileSystemItem
    {
        //The Following variable is going to hold all the child components of a composite components
        private List<FileSystemItem> Childrens = new List<FileSystemItem>();

        //The Constructor takes the Composite name as the input parameter
        public Directory(string name) : base(name)
        {
        }

        //The following Method is used to add Child Components inside the Composite Component
        public void AddComponent(FileSystemItem NewNode)
        {
            this.Childrens.Add(NewNode);
        }

        //The following Method is used to Remove Child Components inside the Composite Component
        public void RemoveComponent(FileSystemItem RemoveNode)
        {
            this.Childrens.Remove(RemoveNode);
        }

        //Override the FileSystemItem class GetSizeinKB Method
        public override decimal GetSizeinKB()
        {
            // Summarizing the size of children
            return this.Childrens.Sum(x => x.GetSizeinKB());
        }
    }
}
