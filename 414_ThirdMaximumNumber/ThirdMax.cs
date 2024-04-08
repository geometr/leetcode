using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _414_ThirdMaximumNumber
{
    public static class ThirdMax
    {
        public static int Solution(int[] nums) {
            int max = nums[0];
            int? med = null;
            int? low = null;
            for (int i = 1; i < nums.Length; i++) {
                int num = nums[i];
                
                if ((num == max) || (num == med) || (num == low)) continue;

                if (num < max is false) (max, med, low) = (num, max, med);
                else if (num < med is false) (med, low) = (num,med);
                    else if (num < low is false ) low = num;
            }
            return low ?? max;
        }
    }
}
