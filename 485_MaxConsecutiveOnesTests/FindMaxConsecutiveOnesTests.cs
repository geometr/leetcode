using Microsoft.VisualStudio.TestTools.UnitTesting;
using _485_MaxConsecutiveOnes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _485_MaxConsecutiveOnes.Tests
{
    [TestClass()]
    public class FindMaxConsecutiveOnesTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] input = {1,1,0,1,1,1};
            int correct = 3;
            Assert.IsTrue(checkSolution(input, correct));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[] input = { 1, 1, 0, 1};
            int correct = 2;
            Assert.IsTrue(checkSolution(input, correct));
        }
        [TestMethod()]
        public void SolutionTest3()
        {
            int[] input = { 0 };
            int correct = 0;
            Assert.IsTrue(checkSolution(input, correct));
        }
        [TestMethod()]
        public void SolutionTest4()
        {
            int[] input = { 1,0,1,1,0,1 };
            int correct = 2;
            Assert.IsTrue(checkSolution(input, correct));
        }
        [TestMethod()]
        public void SolutionTest5()
        {
            int[] input = { 1 };
            int correct = 1;
            Assert.IsTrue(checkSolution(input, correct));
        }
        [TestMethod()]
        public void SolutionTest6()
        {
            int[] input = {0,0};
            int correct = 0;
            Assert.IsTrue(checkSolution(input, correct));
        }
        private bool checkSolution(int[] input, int correct) {
            int answer = FindMaxConsecutiveOnes.Solution(input);
            if (answer==correct) return true;
            return false;
        }

    }
}