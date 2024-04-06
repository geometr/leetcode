using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _905_SortArrayByParity
{
    public static class SortArrayByParity
    {
        public static int[] Solution(int[] nums) {
            int rightCursor = nums.Length - 1;
            int leftCursor = 0;
            while (leftCursor < rightCursor) { 
           
                if ((nums[leftCursor]%2) != 0)
                {
                    bool needInsert = true;
                    while (needInsert && rightCursor>leftCursor) {
                        if (nums[rightCursor] % 2 != 0)
                        {
                            rightCursor--;
                        }
                        else 
                        {
                            int value = nums[leftCursor];
                            nums[leftCursor] = nums[rightCursor];
                            nums[rightCursor] = value;
                            needInsert = false;
                            leftCursor++;
                            rightCursor--;
                        }
                    }
                }
                else
                {
                    leftCursor++;
                }
            }
            return nums;
        }
    }
}
