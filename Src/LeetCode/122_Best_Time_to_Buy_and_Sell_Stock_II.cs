using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BestTimetoBuyandSellStockII
    {
        public int Solution(int[] prices)
        {
            var result = 0;
            if (prices != null && prices.Length > 1)
            {
                for (int i = 1; i < prices.Length; i++)
                {
                    var added = prices[i] - prices[i - 1];
                    if (added > 0)
                        result += added;
                }
            }
            return result;
        }
    }
}
