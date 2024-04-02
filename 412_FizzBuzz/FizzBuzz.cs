using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _412_FizzBuzz
{
    public static class FizzBuzz
    {
        public static IList<string> Solution(int n)
        {
            List<string> answer = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    answer.Add("FizzBuzz");
                    continue;
                }
                if (i % 3 == 0)
                {
                    answer.Add("Fizz");
                    continue;
                }
                if (i % 5 == 0)
                {
                    answer.Add("Buzz");
                    continue;
                }
                answer.Add(i.ToString());
            }
            GC.Collect();
            return answer;
        }
    }
}
