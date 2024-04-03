using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _485_MaxConsecutiveOnes
{
    public static class FindMaxConsecutiveOnes
    {
        public static int Solution(int[] nums) {
            int maxLen = 0;
            int currentLen = 0;
            int searchingNum = 1;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == searchingNum) {
                    currentLen++;
                }
                else
                {
                    currentLen = 0;
                }
                if (currentLen > maxLen) maxLen = currentLen;
            }
            return maxLen;
        }
    }
}
