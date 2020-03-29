using System;
using System.Collections.Generic;
using System.Linq;
namespace codwars.leetcode
{
    public class March28
    {
        //
        public int[] TwoSum(int[] nums, int target)
        {
            var arrayAsList = nums.ToList();
            List<int> addends = new List<int>();
            var secondIndex = 0;
            for (int i = 0; i < arrayAsList.Count; i++)
            {
                var foundTarget = arrayAsList
                        .Where((n, j) => n + arrayAsList[i] == target && i != j)
                        .ToList();
                if (foundTarget.Count() > 0)
                {
                    addends.Add(i);
                    addends.Add(arrayAsList.LastIndexOf(foundTarget[0]));
                    break;
                }
            }
            return addends.ToArray();
        }

        //
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var reversed1 = string.Join("", l1).ToList();
            reversed1.Reverse();
            var reversed2 = string.Join("", l2).ToList();
            reversed2.Reverse();
            var finalArray = (Convert.ToInt32(string.Join("", reversed1)) +
                                Convert.ToInt32(string.Join("", reversed2))).ToString().ToList();
            //return finalArray.Reverse();
            return null;
        }
    }

     public class ListNode
    {
         public int val;
         public ListNode next;
         public ListNode(int x) { val = x; }
     }
}

