using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1299_ReplaceElementsWithGreatestElementOnRightSide
{
    public static class ReplaceElements
    {
        public static int[] Solution(int[] arr)
        {
            int max = arr[arr.Length - 1];
            arr[arr.Length - 1] = -1;
            for (int i = arr.Length-2; i >= 0; i--)
            {
                int currentVal = arr[i];
                arr[i] = max;
                if (currentVal > max) max = currentVal;
            }
            return arr;
        }
    }
}
