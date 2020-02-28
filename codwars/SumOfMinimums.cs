using System;
using System.Collections.Generic;

namespace codwars
{
    public class SumOfMinimums
    {
        public SumOfMinimums()
        {
        }

        public int getSumOfMinimums(int[,] numbers)
        {
            Console.WriteLine(numbers);
            List<int> list = new List<int>();
            foreach (var item in numbers)
            {
                list.Add(item);
            }
            list.Sort();
            return list[0] + list[1];
        }
    }
}
