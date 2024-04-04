using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_RemoveElement
{
    public static class RemoveElement
    {
        public static int Solution(int[] nums, int val) {
            int j = 0;
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
                i++;
            }
            return j;
        }
    }
}
