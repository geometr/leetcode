namespace _26_RemoveDuplicatesFromSortedArray
{
    public static class RemoveDuplicates
    {
        public static int Solution(int[] nums) {
            if (nums.Length == 1) return 1;
            int newLen = 1;
            int index = 1;
            int insertPosition = 1;
            while(index < nums.Length)
            {
                if (nums[index] != nums[index - 1]) { 
                    nums[insertPosition] = nums[index];
                    insertPosition++;
                    newLen++;
                }
                index++;
            }
            return newLen;

        }
    }
}
