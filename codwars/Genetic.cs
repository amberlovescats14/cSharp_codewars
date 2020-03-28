using System;
using System.Collections.Generic;
using System.Linq;
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
            var strArray = str.Split(' ');
            var teest = "Amber".SplitOnEvery();
            var name = "Amber";
            var peep = "".Pop(ref name);
            Console.WriteLine("name: "+name);
            Console.WriteLine("peep: "+peep);
            var venkat = "Venkat".ToArray();
            foreach (var item in venkat)
            {
                Console.WriteLine("item: "+item);
            }

            return str;
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
        public static string Pop(this string str, ref string mutate)
        {
            var last = mutate[mutate.Length - 1];
            var newstr = mutate.SplitOnEvery().SkipLast(1);
            mutate = String.Join("", newstr);
            return last.ToString();
        }
    }
}
