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
                    var isAdded = false;
                    for (int i = 0; i < intervals.Count - 1; i++)
                    {
                        if (intervals[i].end <= newInterval.start && intervals[i + 1].start > newInterval.start)
                        {
                            isAdded = true;
                            result.Add(intervals[i]);
                            if (intervals[i].end >= newInterval.start)
                            {
                                intervals[i].end = Math.Max(intervals[i].end, newInterval.end);
                            }
                            else
                            {
                                result.Add(newInterval);
                            }
                        }
                        else if (intervals[])
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
