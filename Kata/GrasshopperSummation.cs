using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public static class GrasshopperSummation
    {
        public static int summation(int num)
        {
            return Enumerable.Range(1, num).Sum();
        }
    }
}
