using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace codwars.leetcode
{
    public class March29
    {
        public int LengthOfLongestSubstring(string s)
        {
            var temp = string.Empty;
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < s.ToArray().Length; i++)
            {
                Console.WriteLine(builder.ToString());
                if (builder.ToString().Contains(s[i]))
                {
                    if(temp.Length < builder.ToString().Length)
                    {
                    temp = builder.ToString();
                    }
                    builder.Clear();
                    builder.Append(s[i]);
                    continue;
                }
                else
                {
                    builder.Append(s[i]);
                }
            }
            return temp.Length;
        }
    }
}
