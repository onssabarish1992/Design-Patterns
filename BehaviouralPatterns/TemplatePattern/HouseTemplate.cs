using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class HouseTemplate
    {
        public void BuildHouse()
        {
            //Step 1
            BuildFoundation();

            //Step 2
            BuildPillars();

            //Step 3
            BuildWalls();

            //Step4
            BuildWindows();

            Console.WriteLine("House Building Complete");

        }

        protected abstract void BuildWindows();

        protected abstract void BuildWalls();

        protected abstract void BuildPillars();

        protected abstract void BuildFoundation();
    }
}
