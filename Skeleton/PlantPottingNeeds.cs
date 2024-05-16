using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.Skeleton
{
    internal interface PlantPottingNeeds
    {
        public void GetSoil();
        public void GetPot();
    }
    }
    internal abstract class PlantPottingNeeds2
    {
        public void GetSoil()
        {
            Console.WriteLine("djbf");
        }
        public void GetPot()
        {
            Console.WriteLine("djbf");
        }
    }
}
