using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Kata
{
    internal class EqualSidesOfAnArray
    {
        public static int FindEvenIndex(int[] arr)
        {
            int totalSum = 0;
            foreach (int num in arr)
            {
                totalSum += num;
            }

            int leftSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                totalSum -= arr[i];

                if (leftSum == totalSum)
                {
                    return i;
                }

                leftSum += arr[i];
            }

            return -1;
        }
    }
}
