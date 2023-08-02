using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public static class StringRepeat
    {
        public static string RepeatStr(int n, string s)
        {
            string r = "";

            for (int i = 0; i < n; i++)
            {
                r += s;
            }

            return r;
        }
    }
}
