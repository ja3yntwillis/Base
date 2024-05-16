using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp.BaseCalculations
{
    internal class Division
    {
        static int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException("Divisor cannot be zero.");
            }

            int quotient = dividend / divisor;
            return quotient;
        }
    }
}
