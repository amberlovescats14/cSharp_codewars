using System;
using System.Collections.Generic;
using System.Linq;
namespace codwars.leetcode
{
    public class March28
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var arrayAsList = nums.ToList();
            List<int> addends = new List<int>();
            for (int i = 0; i < arrayAsList.Count; i++)
            {
                var foundTarget = nums
                        .Where((n, j) =>
                        {
                            Console.WriteLine(j);
                            return true;
                        })

                        .ToList();
                if (foundTarget.Count() > 0)
                {
                    Console.WriteLine("FOUND");
                    Console.WriteLine(arrayAsList[i]);
                    addends.Add(i);
                    addends.Add(arrayAsList.IndexOf(foundTarget[0]));
                    break;
                }
            }
            return addends.ToArray();
        }
    }
}
