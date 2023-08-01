using System;

namespace Kata
{
    public static class DescendingOrder
    {
        public static int ArrangeDescending(int num)
        {
            string numStr = num.ToString;
            char[] digits = numStr.ToCharArray;

            Array.Sort(digits);
            Array.Reverse(digits);

            string resultStr = new string(digits);
            int    result    = int.Parse(resultStr);

            return result;
        }
    }
}