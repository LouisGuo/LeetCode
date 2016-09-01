using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LRUCache
    {
        private List<int> keys;
        private Dictionary<int, int> values;


        public LRUCache(int capacity)
        {
            this.keys = new List<int>(capacity);
            this.values = new Dictionary<int, int>(capacity);
        }

        public int Get(int key)
        {
            if (keys.Remove(key))
            {
                keys.Add(key);
                return values[key];
            }
            else
                return -1;
        }

        public void Set(int key, int value)
        {
            if (keys.Remove(key))
            {
                keys.Add(key);
                values[key] = value;
            }
            else
            {
                if (keys.Count == keys.Capacity)
                {
                    values.Remove(keys[0]);
                    keys.RemoveAt(0);
                }
                keys.Add(key);
                values[key] = value;
            }
        }
    }
}
