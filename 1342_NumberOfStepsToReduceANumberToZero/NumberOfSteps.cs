using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1342_NumberOfStepsToReduceANumberToZero
{
    public static class NumberOfSteps
    {
        public static int Solution(int num) {
            int answer = 0;
            while (num != 0)
            {
                if ((num & 1) == 0)
                {
                    num = num >> 1;
                }
                else
                {
                    num--;
                }
                answer++;
            }
            return answer;
        }
    }
}
