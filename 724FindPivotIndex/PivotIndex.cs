namespace _724FindPivotIndex
{
    public static class PivotIndex
    {
        public static int Solution(int[] nums) {
            int rightSum = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                rightSum += nums[i];
            }
            int leftSum = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == rightSum)
                {
                    return i;
                }
                leftSum += nums[i];
                if (i + 1 < nums.Length)
                {
                    rightSum -= nums[i + 1];
                }
            }

            return -1;
        }

    }
}
