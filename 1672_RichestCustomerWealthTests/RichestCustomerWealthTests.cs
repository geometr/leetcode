using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1672_RichestCustomerWealth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1672_RichestCustomerWealth.Tests
{
    [TestClass()]
    public class RichestCustomerWealthTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[][] accounts = { new int[]{ 1, 2, 3 }, new int[] { 3, 2, 1 } };
            int correct = 6;
            Assert.IsTrue(checkSolution(accounts, correct));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[][] accounts = { new int[] { 1, 5 }, new int[] { 7,3 }, new int[] { 3,5 } };
            int correct = 10;
            Assert.IsTrue(checkSolution(accounts, correct));
        }
        [TestMethod()]
        public void SolutionTest3()
        {
            int[][] accounts = { new int[] { 2, 8, 7 }, new int[] { 7, 1, 3 }, new int[] { 1, 9, 5 } };
            int correct = 17;
            Assert.IsTrue(checkSolution(accounts, correct));
        }

        private Boolean checkSolution(int[][] accounts, int correct) {
            int result = RichestCustomerWealth.Solution(accounts);
            return result == correct;
        }
    }
}