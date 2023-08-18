using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal class Population
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int pop   = p0;
            int count = 0;

            while (pop < p)
            {
                pop   += (int)(pop * percent / 100); // Convert percent to a fraction
                pop   += aug;
                count += 1;
            }

            return count;
        }
    }
}
