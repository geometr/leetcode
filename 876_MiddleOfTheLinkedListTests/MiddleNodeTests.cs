using Microsoft.VisualStudio.TestTools.UnitTesting;
using _876_MiddleOfTheLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometr.ListNode;

namespace _876_MiddleOfTheLinkedList.Tests
{
    [TestClass()]
    public class MiddleNodeTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            ListNode l1 = Helper.initializeListFromArray(new int[] { 1, 2, 3, 4, 5 });
            ListNode correct = Helper.initializeListFromArray(new int[] { 3, 4, 5 });
            Assert.IsTrue(checkSolution(l1, correct));
        }

        [TestMethod()]
        public void SolutionTest2()
        {
            ListNode l1 = Helper.initializeListFromArray(new int[] { 1, 2, 3, 4, 5, 6 });
            ListNode correct = Helper.initializeListFromArray(new int[] { 4, 5, 6 });
            Assert.IsTrue(checkSolution(l1, correct));
        }
        private Boolean checkSolution(ListNode l1, ListNode correct)
        {
            ListNode result = MiddleNode.Solution(l1);
            do
            {
                if (correct.val != result.val) return false;
                correct = correct.next;
                result = result.next;
            } while (correct != null || result != null);

            return true;
        }

    }
}