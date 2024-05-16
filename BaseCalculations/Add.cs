using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.BaseCalculations
{
    public class Add
    {
        public  int a = 8;
        public int add(int x, int y)
        {
            var result = x + y;
            return result;
        }
        public int add(int x, int y, int z)
        {
            var result = x + y + z;
            return result;
        }
        public int add(List<int> list)
        {
            int result = 0;
            for (int i = 0; i < list.Count; i++)
            {
                result = result + list[i];
            }
            return result;
        }

    }
}
