using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGerom.ListNode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public static class Helper {
        public static ListNode initializeListFromArray(int[] inputArrayList)
        {
            if (0 == inputArrayList.Length) return new ListNode();

            ListNode rootNode = new ListNode(inputArrayList[0]);
            ListNode lastNode = rootNode;
            for (int i = 1; i < inputArrayList.Length; i++)
            {
                lastNode.next = new ListNode(inputArrayList[i]);
                lastNode = lastNode.next;
            }
            return rootNode;
        }
    }
}
