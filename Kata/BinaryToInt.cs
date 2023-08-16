using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    internal class BinaryToInt
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            int result = 0;
            int count  = 0;

            for (int i = BinaryArray.Length - 1; i >= 0; i--)
            {
                result += BinaryArray[i] * (int)Math.Pow(2, count);
                count++;
            }

            return result;
        }
    }
}
