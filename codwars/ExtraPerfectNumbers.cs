using System;
using System.Collections.Generic;

namespace codwars
{
    public class ExtraPerfectNumbers
    {
        public ExtraPerfectNumbers()
        {
        }
        public int[] getExtraPerfectNumbers(int n)
        {
            var perfectNumbers = new List<int>();
            for (int i = 1; i <= n; i+=2)
            {
                perfectNumbers.Add(i);
            }
            return perfectNumbers.ToArray();
        }
    }
}
