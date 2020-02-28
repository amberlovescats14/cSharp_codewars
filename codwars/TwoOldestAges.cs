using System;
using System.Collections.Generic;

namespace codwars
{
    public class TwoOldestAges
    {
        public TwoOldestAges()
        {
            Console.WriteLine("hello");
        }

        public  int[] getAges(int[] ages)
        {
            List<int> listOfAges = new List<int>();
            listOfAges.AddRange(ages);
            listOfAges.Sort();
            int[] twoOldest = new int[]
                {listOfAges[listOfAges.Count-2],listOfAges[listOfAges.Count-1] };
        
            return twoOldest;
        }
    }
}
