using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1346_CheckIfNAndItsDoubleExits
{
    public static class CheckIfExits
    {
        public static bool Solution(int[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (i == j) continue;
                    if (arr[i] == 2 * arr[j]) return true;
                }
            }
            return false;
        }
    }
}
