using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1089_DuplicateZeros
{
    public static class DuplicateZeros
    {
        public static void Solution(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) { 
                if (arr[i] == 0)
                {
                    for (int j = arr.Length - 1; j > i; j--) 
                    {
                        arr[j] = arr[j - 1];
                    }
                    i++;
                }
            }
        }
    }
}