namespace _66_PlusOne
{
    public static class PlusOne
    {
        public static int[] Solution(int[] digits) {
            bool carry = true;
            int index = digits.Length - 1;
            while (carry)
            {
                digits[index]++;
                if (digits[index] >= 10)
                {
                    digits[index] -= 10;
                    carry = true;
                }
                else
                {
                    carry = false;
                }
                index--;

                if (index < 0)
                    break;
            }
            int[] result = digits;
            if (index < 0 && carry)
            {
                result = new int[digits.Length + 1];
                for (int i = 0; i < digits.Length; i++)
                {
                    result[i + 1] = digits[i];
                }
                result[0] = 1;
            }
            return result;
        }
    }
}
