using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1295_FindNumbersWithEvenNumberOfDigits
{
    public static class FindNumbers
    {
        public static int Solution(int[] nums) {
            int numberOfEvenNumbers = 0;
            foreach (int num in nums) {
                int number = num;
                int numOfDigit = 1;
                while (number > 9) {
                    number = number / 10;
                    numOfDigit++;
                }
                if (numOfDigit % 2 == 0) numberOfEvenNumbers++;
            }
            return numberOfEvenNumbers;
        }
    }
}
