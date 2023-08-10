using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kata
{
    internal class PosandNegatives
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || !input.Any())
            {
                return new int[] { };
            }

            int countPositives = input.Count(n => n > 0);
            int sumNegatives   = input.Where(n => n < 0).Sum();

            return new int[] { countPositives, sumNegatives };
        }
    }
}
