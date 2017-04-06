using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _412_Fizz_Buzz
    {
        public IList<string> FizzBuzz(int n)
        {
            var result = new List<String>();
            for (int i = 1; i < n + 1; i++)
            {
                result.Add(i.ToString());
            }
            for (int i = 1; i * 3 <= n; i++)
            {
                result[i * 3 - 1] = "Fizz";
            }
            for (int i = 1; i * 5 <= n; i++)
            {
                if (result[i * 5 - 1].Equals("Fizz"))
                {
                    result[i * 5 - 1] = "FizzBuzz";
                }
                else
                {
                    result[i * 5 - 1] = "Buzz";
                }
            }
            return result;
        }
    }
}
