using System;

namespace codwars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //var ages = new int[] { 10, 50, 30, 40 };
            //var oldest = new TwoOldestAges().getAges(ages);
            //Console.WriteLine(string.Join(",",oldest));

            var population = new GrowthOfAPopulation();
            //var numberOfYears = population.getAmountOfYears(1500, 5, 100, 5000);
            //Console.WriteLine("number: " + numberOfYears);

            var multiDemensionArrays = new SumOfMinimums();
            //multiDemensionArrays.getSumOfMinimums(new int[2, 3] { { 1, 2, 3 }, { 3, 4, 5 } });

            //var perfectNumbers = new ExtraPerfectNumbers().getExtraPerfectNumbers(3);
            //Console.WriteLine(string.Join(' ', perfectNumbers));

            //var missingValues = new MissingValues()
            //        .getMissingValues(new int[] { 1, 1, 1, 2, 2, 3 });

            //var pig = Genetic.PigIt("Pig Latin");
            //Console.WriteLine(pig);

            //var march28 = new leetcode.March28();
            //var matches = march28.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            //Console.WriteLine(string.Join(",", matches));

            var march29 = new leetcode.March29();
            march29.LengthOfLongestSubstring("dvdf");
        }

    }
}
