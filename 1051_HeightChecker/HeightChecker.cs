using System;


namespace _1051_HeightChecker
{
    public static class HeightChecker
    {
        public static int Solution(int [] heights)
        {
            int[] sortered = new int[heights.Length];
            Array.Copy(heights, 0, sortered, 0, heights.Length);
            Array.Sort(sortered);
            int diff = 0;
            for (int i = 0; i < heights.Length; i++) {
                if (heights[i] != sortered[i]) diff++;
            }
            return diff;
        }
    }
}
