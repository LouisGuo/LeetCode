using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LetterCombinationsofaPhoneNumber
    {
        public IList<string> Solution(string digits)
        {
            var result = new List<char[]>();
            if (digits != null && digits.Length > 0)
            {
                var letterDic = new Dictionary<char, char[]>
                {
                    { '2',new char[] {'a','b','c' } },
                    { '3',new char[] {'d','e','f' } },
                    { '4',new char[] {'g','h','i' } },
                    { '5',new char[] {'j','k','l' } },
                    { '6',new char[] {'m','n','o' } },
                    { '7',new char[] {'p','q','r','s' } },
                    { '8',new char[] { 't','u','v' } },
                    { '9',new char[] { 'w','x','y','z' } }
                };
                var char1 = letterDic[digits[0]];
                for (int i = 0; i < char1.Length; i++)
                {
                    var temp = new char[digits.Length];
                    temp[0] = char1[i];
                    result.Add(temp);
                }
                for (int i = 1; i < digits.Length; i++)
                {
                    Append(result, letterDic[digits[i]], i);
                }
            }
            return result.Select(c => new String(c)).ToList();
        }

        private void Append(List<char[]> result, char[] ch, int index)
        {
            var resultLength = result.Count;
            for (int i = 1; i < ch.Length; i++)
            {
                for (int j = 0; j < resultLength; j++)
                {
                    var temp = new char[result[0].Length];
                    for (int inner = 0; inner < index; inner++)
                    {
                        temp[inner] = result[j][inner];
                    }
                    temp[index] = ch[i];
                    result.Add(temp);
                }
            }
            for (int i = 0; i < resultLength; i++)
            {
                result[i][index] = ch[0];
            }
        }
    }
}
