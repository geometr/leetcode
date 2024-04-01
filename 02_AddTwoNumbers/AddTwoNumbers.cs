using Geometr.ListNode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AddTwoNumbers
{
 /*
  * Definition for singly-linked list.
  */
    public class AddTwoNumbers
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode last = result;
            Boolean carryFlag = false;
            do {
                int a = 0;
                int b = 0;
                if (l1 != null) a = l1.val;
                if (l2 != null) b = l2.val;
                int sum = a + b;
                if (carryFlag)
                {
                    sum++;
                    carryFlag = false;
                }
                if (sum > 9) {
                    carryFlag = true;
                    sum -= 10;
                }
                
                if (null != l1) l1 = l1.next;
                if (null != l2) l2 = l2.next;

                last.val = sum;

                if ((null != l1) || (null != l2) || carryFlag)
                {
                    last.next = new ListNode();
                    last = last.next;
                }
            } while ((null!=l1) || (null!=l2) || carryFlag);
            return result;

        }

    }
}
