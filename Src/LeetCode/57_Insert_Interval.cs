using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class InsertInterval
    {
        public IList<Interval> Solution(IList<Interval> intervals, Interval newInterval)
        {
            var result = new List<Interval>();
            if (intervals != null && newInterval != null)
            {
                if (intervals.Count == 0)
                    result.Add(newInterval);
                else
                {
                    var current = 0;
                    while (current < intervals.Count && intervals[current].start <= newInterval.start)
                    {
                        result.Add(intervals[current++]);
                    }
                    if (result.Count > 0 && result[result.Count - 1].end >= newInterval.start)
                    {
                        result[result.Count - 1].end = Math.Max(result[result.Count - 1].end, newInterval.end);
                    }
                    else
                    {
                        result.Add(newInterval);
                    }
                    while (current < intervals.Count)
                    {
                        if (result[result.Count - 1].end >= intervals[current].start)
                        {
                            result[result.Count - 1].end = Math.Max(result[result.Count - 1].end, intervals[current].end);
                        }
                        else
                        {
                            result.Add(intervals[current]);
                        }
                        current++;
                    }
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
