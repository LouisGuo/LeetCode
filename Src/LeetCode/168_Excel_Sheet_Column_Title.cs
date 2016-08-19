using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ExcelSheetColumnTitle
    {
        public string Sollution(int n)
        {
            if (n < 0)
                return String.Empty;
            var result = String.Empty;
            n = n - 1;
            while (n !=0)
            {
                result = (Char)(n % 26 + 65) + result;
                n = n / 26;
            }
            return result;
        }
    }
}
