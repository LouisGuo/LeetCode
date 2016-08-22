using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            var middleValues = new List<int>();
            while (!middleValues.Contains(n) && n != 1)
            {
                middleValues.Add(n);
                var middleValue = 0;
                while (n != 0)
                {
                    var tem = n % 10;
                    middleValue += (tem * tem);
                    n /= 10;
                }
                n = middleValue;
            }
            return n == 1;
        }
    }
}
