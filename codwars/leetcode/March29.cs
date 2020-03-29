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
            var tempSubstring = "";
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < s.ToArray().Length; i++)
            {
                if (!builder.ToString().Contains(s[i]))
                {
                    Console.WriteLine(" 1: builder: "+builder.ToString()+" s[i]: "+s[i] +":: "+ i.ToString());
                    builder.Append(s[i]);
                    tempSubstring = builder.ToString();
                    continue;
                }
                if (builder.ToString().Length > tempSubstring.Length)
                {
                    Console.WriteLine("2: buider: "+builder.ToString()+" temp: "+tempSubstring+" :: "+ i.ToString());
                    tempSubstring = builder.ToString();
                    builder.Clear();
                    builder.Append(s[i]);
                }

                else
                {
                    Console.WriteLine("3: builder: "+builder.ToString() + " :: " + i.ToString());
                    builder.Clear();
                    builder.Append(s[i]);
                }
            }
            Console.WriteLine(tempSubstring);
            return tempSubstring.Length;
        }
    }
}
