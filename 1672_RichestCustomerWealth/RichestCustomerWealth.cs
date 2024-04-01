using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1672_RichestCustomerWealth
{
    public static class RichestCustomerWealth
    {
        public static int Solution(int[][] accounts)
        {
            int maxWealth = 0;
            foreach (int []account in accounts)
            {
                int wealth = account.Sum();
                if (wealth > maxWealth) maxWealth = wealth;
            }
            return maxWealth;
        }
    }
}
