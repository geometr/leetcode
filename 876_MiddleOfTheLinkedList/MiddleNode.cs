using Geometr.ListNode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _876_MiddleOfTheLinkedList
{
    public static class MiddleNode
    {
        public static ListNode Solution(ListNode head) {
            int length = 0;
            ListNode pointer = head;
            while (pointer!= null) {
                pointer = pointer.next;
                length++;
            }
            int middle = length / 2;
            for (int i = 0; i < middle; i++) {
                head = head.next;
            }
            return head;
        }
    }
}
