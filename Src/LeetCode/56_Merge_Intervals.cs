using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeIntervals
    {
        public IList<Interval> Solution(IList<Interval> intervals)
        {
            var result = new List<Interval>();
            if (intervals != null && intervals.Count > 0)
            {
                result.Add(intervals[0]);
                for (int i = 1; i < intervals.Count; i++)
                {
                    

                }
            }
            return result;
        }

        public class Interval
        {
            public int start;
            public int end;
            public Interval() { start = 0; end = 0; }
            public Interval(int s, int e) { start = s; end = e; }
        }
    }
}
