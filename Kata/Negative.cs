using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal class Negative
    {
        public static int MakeNegative(int number)
        {
            if (number <= 0)
                return number;
            else
                return number * -1;
        }
    }
}
