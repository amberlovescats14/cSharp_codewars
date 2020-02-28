using System;
using System.Collections.Generic;

namespace codwars
{
    public class GrowthOfAPopulation
    {
        public GrowthOfAPopulation()
        {
        }

        public int getAmountOfYears(int p0, double percent, int aug, int p)
        {
            if (p0 >= p) return 0;
            var increasedPercent = (int)(p0 * (percent/100));
            var totalPopulation = p0 + aug + increasedPercent;
            return 1 + getAmountOfYears(totalPopulation, percent, aug, p);
        }
    }
}
