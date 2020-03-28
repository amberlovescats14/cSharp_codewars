using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codwars
{
    public class Genetic
    {
        public static bool One(int[] arr, Func<int, bool> fun)
        {
            return arr.Where(a => fun(a)).Count() == 1;
        }

        public static string PigIt(string str)
        {
            List<String> formatedWords = new List<string>();
            var strArray = str.Split(' ');
            for (int i = 0; i < strArray.Length; i++)
            {
                StringBuilder builder = new StringBuilder();
                var firstLetter = strArray[i].Unshift(ref strArray[i]);
                builder.Append(strArray[i]);
                builder.Append(firstLetter);
                builder.Append("ay");
                formatedWords.Add(builder.ToString());
            }

            return string.Join(" ", formatedWords);
        }
    }

    public static class Helpers
    {
        public static IEnumerable<string> SplitOnEvery(this string str)
        {
            List<string> stringSeperated = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                stringSeperated.Add(str[i].ToString());
            }
            return (IEnumerable<string>)stringSeperated; 
        }
        public static string Unshift(this string str, ref string mutate)
        {
            var first = mutate[0];
            var newstr = mutate.SplitOnEvery().Skip(1);
            mutate = String.Join("", newstr);
            return first.ToString();
        }
        public static string Unshift(this string str)
        {
            return str[str.Length - 1].ToString();
        }
    }
}
