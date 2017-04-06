using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _535_Encode_and_Decode_TinyURL
    {
        public string encode(string longUrl)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(longUrl));
        }

        public string decode(string shortUrl)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(shortUrl));
        }
    }
}
