using System;
using System.Collections.Generic;
using System.Linq;

namespace codwars
{
    public class MissingValues
    {
        public MissingValues()
        {
        }

        public int getMissingValues(int[] arr)
        {
            var numbersToMultiply = new int[3];
            var hash = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (!hash.ContainsKey(item)) hash.Add(item, 1);
                else hash[item] += 1;
            }
            foreach (var item in hash)
            {
                if (item.Value == 2) numbersToMultiply[0] = item.Key;
                else if (item.Value == 1)
                {
                    numbersToMultiply[1] = item.Key;
                    numbersToMultiply[2] = item.Key;
                }
                else continue;
            }
            var reduce = numbersToMultiply.Aggregate((x, y) => x * y);
            Console.WriteLine("reduce: " + reduce);
            return 0;
        }
    }
}
