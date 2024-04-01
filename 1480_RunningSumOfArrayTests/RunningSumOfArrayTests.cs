using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1480_RunningSumOfArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1480_RunningSumOfArray.Tests
{
    [TestClass()]
    public class RunningSumOfArrayTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] input = new int[] { 1, 2, 3, 4 };
            int[] correct = new int[] {1, 3, 6, 10};

            Assert.IsTrue(checkSolution(input, correct));
            
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[] input = new int[] { 1, 1, 1, 1, 1 };
            int[] correct = new int[] { 1, 2, 3, 4, 5 };

            Assert.IsTrue(checkSolution(input, correct));

        }
        [TestMethod()]
        public void SolutionTest3()
        {
            int[] input = new int[] { 3, 1, 2, 10, 1};
            int[] correct = new int[] { 3, 4, 6, 16, 17 };

            Assert.IsTrue(checkSolution(input, correct));

        }
        private Boolean checkSolution(int[] input, int[] correct)
        {
            int[] result = RunningSumOfArray.Solution(input);

            for (int i = 0; i < correct.Length; i++)
                if (result[i] != correct[i]) return false;
            return true;

        }
    }
}