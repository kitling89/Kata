using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Kata
{
    internal class MaskString
    {
        // return masked string
        public static string Maskify(string cc)
        {
            if (cc == null || cc.Length <= 4)
            {
                return cc;
            }

            int    maskedLength = cc.Length                     - 4;
            string maskedString = new string('#', maskedLength) + cc.Substring(maskedLength);
            return maskedString;
        }
    }
}
