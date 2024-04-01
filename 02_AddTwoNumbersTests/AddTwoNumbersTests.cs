using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02_AddTwoNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometr.ListNode;

namespace _02_AddTwoNumbers.Tests
{
    [TestClass()]
    public class AddTwoNumbersTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            ListNode l1 = Helper.initializeListFromArray(new int[] {2, 4, 3});
            ListNode l2 = Helper.initializeListFromArray(new int[] {5, 6, 4});
            ListNode correct = Helper.initializeListFromArray(new int[] { 7, 0, 8 });
            checkSolution(l1, l2, correct);
        }

        [TestMethod()]
        public void SolutionTest2()
        {
            ListNode l1 = new ListNode(0);
            ListNode l2 = new ListNode(0);
            ListNode correct = new ListNode(0);
            checkSolution(l1, l2, correct);
        }
        [TestMethod()]
        public void SolutionTest3()
        {
            ListNode l1 = Helper.initializeListFromArray(new int[] { 9, 9, 9, 9, 9, 9, 9 });
            ListNode l2 = Helper.initializeListFromArray(new int[] { 9, 9, 9, 9 });
            ListNode correct = Helper.initializeListFromArray(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 });
            checkSolution(l1, l2, correct);
        }
        private void checkSolution(ListNode l1, ListNode l2, ListNode correct) {
            ListNode result = AddTwoNumbers.Solution(l1, l2);
            do
            {
                if (correct.val != result.val) Assert.Fail();
                correct = correct.next;
                result = result.next;
            } while (correct != null || result != null);

            Assert.IsTrue(true);
        }
    }
}