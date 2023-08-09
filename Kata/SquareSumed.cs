using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal class SquareSumed
    {
        public static int SquareSum(int[] numbers)
        {
            return numbers.Sum(number => number * number);
        }
    }
}
