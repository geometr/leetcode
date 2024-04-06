namespace _283_MoveZeroes
{
    public static class MoveZeroes
    {
        public static void Solution(int[] nums) {
            int cursor = 0;
            int zeroNum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroNum++;
                }
                else {
                    nums[cursor] = nums[i];
                    cursor++;
                    
                }
            }
            for (int i = nums.Length-zeroNum; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
