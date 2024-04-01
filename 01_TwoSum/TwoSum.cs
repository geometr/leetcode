using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TwoSum
{
    public static class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
            /*  for (int i = 0; i < nums.Length-1; i++)
              {
                  for (int j = i + 1; j < nums.Length; j++)
                  {
                      if (target == (nums[i] + nums[j]))
                          return new int[] { i, j };
                  }
              }
              return new int[] { -1, -1 };*/

            var dictonary = new Dictionary<int, int>();
            for (int i = 0; i< nums.Length; i++)
            {
                if (dictonary.ContainsKey(target - nums[i]))
                    return new int[] { dictonary[target - nums[i]], i };
                else
                {
                    if (!dictonary.ContainsKey(nums[i])) dictonary.Add(nums[i], i);
                }
                   
                   
            }
            return default;
        }
    }
}