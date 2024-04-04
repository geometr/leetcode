using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88_MergeSortedArray
{
    public static class Merge
    {
        public static void Solution(int[] nums1, int m, int[] nums2, int n)
        {
            int pointer1 = m-1;
            int pointer2 = n-1;
            int index = nums1.Length-1;
            while (index >= 0) {
                int val1 = -9999999;
                if (pointer1 >= 0) { 
                    val1 = nums1[pointer1];
                }
                int val2 = -9999999;
                if (pointer2 >= 0)
                {
                    val2 = nums2[pointer2];
                }
                if (val1 > val2) {
                    nums1[index] = val1;
                    if (pointer1 >= 0)
                    {
                        pointer1--;
                    }
                }
                else
                {
                    nums1[index] = val2;
                    if (pointer2 >= 0)
                    {
                        pointer2--;
                    }
                }
                index--;
            }
        }
    }
}
