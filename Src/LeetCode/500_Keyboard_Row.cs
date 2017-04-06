using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _500_Keyboard_Row
    {
        public string[] FindWords(string[] words)
        {
            var result = new List<String>();
            var rowWords = new List<List<String>>()
            {
                new List<string>{"q","w","e","r","t","y","u","i","o","p", "Q","W","E","R","T","Y","U","I","O","P"},
                new List<string>{ "a","s","d","f","g","h","j","k","l","A" ,"S","D","F","G","H","J","K","L", },
                new List<string>{ "z", "x", "c", "v", "b", "n", "m", "Z", "X", "C", "V", "B", "N", "M" }
            };
            var wordsList = new List<List<String>>();
            for (int i = 0; i < words.Length; i++)
            {
                wordsList.Add(words[i].ToArray().Distinct().Select(c => c.ToString()).ToList());
            }
            for (int i = 0; i < words.Length; i++)
            {
                foreach (var row in rowWords)
                {
                    if (wordsList[i].Intersect(row).Count() == wordsList[i].Count)
                        result.Add(words[i]);
                }
            }
            return result.ToArray();
        }
    }
}
