using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IntegertoEnglishWords
    {
        public string Solution(int num)
        {
            if (num > 0)
            {
                var result = new StringBuilder();
                var numDic = new Dictionary<int, string>()
                {
                    { 0,""},
                    { 1,"One "},
                    { 2,"Two "},
                    { 3,"Three "},
                    { 4,"Four "},
                    { 5,"Five "},
                    { 6,"Six "},
                    { 7,"Seven "},
                    { 8,"Eight "},
                    { 9,"Nine "},
                    { 10,"Ten "},
                    { 11,"Eleven "},
                    { 12,"Twelve "},
                    { 13,"Thirteen "},
                    { 14,"Fourteen "},
                    { 15,"Fifteen "},
                    { 16,"Sixteen "},
                    { 17,"Seventeen "},
                    { 18,"Eighteen "},
                    { 19,"Nineteen "},
                    { 20,"Twenty "},
                    { 30,"Thirty "},
                    { 40,"Forty "},
                    { 50,"Fifty "},
                    { 60,"Sixty "},
                    { 70,"Seventy "},
                    { 80,"Eighty "},
                    { 90,"Ninety "},
                };
                var levelString = new string[] { " ", "Thousand ", "Million ", "Billion " };
                var numStr = num.ToString();
                var splitLength = numStr.Length / 3;
                var firstLength = numStr.Length % 3;
                if (firstLength != 0)
                {
                    splitLength++;
                }
                else
                {
                    firstLength = 3;
                }
                var split = new int[splitLength];
                split[0] = int.Parse(numStr.Substring(0, firstLength));
                for (int i = 0; i < split.Length - 1; i++)
                {
                    split[i + 1] = int.Parse(numStr.Substring(i * 3 + firstLength, 3));
                }
                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i] > 0)
                    {
                        if (split[i] <= 20)
                        {
                            result.Append(numDic[split[i]]);
                        }
                        else
                        {
                            var hundred = split[i] / 100;
                            if (hundred > 0)
                            {
                                result.Append(numDic[hundred]);
                                result.Append("Hundred ");
                                split[i] = split[i] - 100 * hundred;
                            }
                            if (split[i] <= 20)
                            {
                                result.Append(numDic[split[i]]);
                            }
                            else
                            {
                                var tens = split[i] / 10;
                                result.Append(numDic[tens * 10]);
                                result.Append(numDic[split[i] % 10]);
                            }
                        }
                        result.Append(levelString[split.Length - i - 1]);
                    }
                }
                return result.ToString().Trim();
            }
            else
            {
                return "Zero";
            }
        }
    }
}
