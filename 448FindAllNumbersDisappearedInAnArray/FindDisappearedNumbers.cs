using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _448FindAllNumbersDisappearedInAnArray
{
    public static class FindDisappearedNumbers
    {
        public static IList<int> Solution(int[] nums) {
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if( nums[index]>0) nums[index] = -nums[index];
            }
            IList<int> returnLst = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    returnLst.Add(i + 1);
                }
            }
            return returnLst;
        }
    }
}
