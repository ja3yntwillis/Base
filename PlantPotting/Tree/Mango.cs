using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsoleApp.Skeleton;

namespace TestConsoleApp.Plant.Tree
{
    internal class Mango: PlantPottingNeeds
    {
        public void GetSeed()
        {
            Console.WriteLine("Plant a Mango Seed");
        }
        
        public void GetSapling()
        {
            Console.WriteLine("Plant a Mango Sapling");
        }

        public void GetSoil()
        {
            throw new NotImplementedException();
        }

        public void GetPot()
        {
            throw new NotImplementedException();
        }
    }
}
