using System;

namespace codwars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ages = new int[] { 10, 50, 30, 40 };
            //var oldest = new TwoOldestAges().getAges(ages);
            //Console.WriteLine(string.Join(",",oldest));

            var population = new GrowthOfAPopulation();
            //var numberOfYears = population.getAmountOfYears(1500, 5, 100, 5000);
            //Console.WriteLine("number: " + numberOfYears);

            var multiDemensionArrays = new SumOfMinimums();
            //multiDemensionArrays.getSumOfMinimums(new int[2, 3] { { 1, 2, 3 }, { 3, 4, 5 } });

            var perfectNumbers = new ExtraPerfectNumbers().getExtraPerfectNumbers(3);
            Console.WriteLine(string.Join(' ', perfectNumbers));

        }

    }
}
