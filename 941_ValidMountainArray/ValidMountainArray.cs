using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _941_ValidMountainArray
{
    public static class ValidMountainArray
    {
        public static bool Solution(int[] arr)
        {
            bool inc = true;
            bool leftPlato = false;
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1]) return false;
                if ((arr[i] > arr[i - 1])&&inc)
                {
                    leftPlato = true;
                    if ((arr[i] > max)&&inc)
                    {
                        max = arr[i];
                    }
                    else
                    {
                        inc = false;
                        continue;
                    }
                }
                if (arr[i] < arr[i - 1])
                {
                    if (inc && !leftPlato) return false;  
                    if (inc) inc = false;
                    continue;
                }
                if (!inc&&(arr[i] > arr[i - 1]))
                {
                 
                    return false;
                }
            };
            if (inc) return false;
            if (!leftPlato) return false;
            return true;
        }
    }
}
