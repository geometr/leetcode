using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _977_SquaresOfASortedArray
{
    public static class SortedSquares
    {
        public static int[] Solution(int[] nums) {
            int[] res = new int[nums.Length];
            int left = 0;
            int right = nums.Length - 1;
            int index = right;
            while (left <= right) {
                int leftVal = nums[left] * nums[left];
                int rightVal = nums[right] * nums[right];
                if (leftVal > rightVal) {
                    res[index] = leftVal;
                    left++;
                } else {
                    res[index] = rightVal;
                    right--;
                }
                index--;
            }

            return res;
        }
    }
}
