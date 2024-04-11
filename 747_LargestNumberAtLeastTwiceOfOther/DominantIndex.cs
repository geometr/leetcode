namespace _747_LargestNumberAtLeastTwiceOfOther
{
    public static class DominantIndex
    {
        public static int Solution(int[] nums)
        {
            int max = nums[0];
            int? second = null;
            int maxPos = 0;

            for (int i = 1; i < nums.Length; i++)
            {

                if (nums[i] > max)
                {
                    second = max;
                    max = nums[i];
                    maxPos = i;
                }
                else
                {
                    if (nums[i] > second || second ==null)
                    {
                        second = nums[i];
                    }

                }
            }
            return max>= second * 2  ? maxPos : -1;
        }
    }
}
