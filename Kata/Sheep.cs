using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal class Sheep
    {
        public static int CountSheeps(bool[] sheeps)
        {
            int count = 0;
            foreach (var VARIABLE in sheeps)
            {
                if (VARIABLE == true)
                    count += 1;
            }

            return count;
        }
    }
}
