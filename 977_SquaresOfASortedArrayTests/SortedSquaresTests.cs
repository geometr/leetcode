using Microsoft.VisualStudio.TestTools.UnitTesting;
using _977_SquaresOfASortedArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _977_SquaresOfASortedArray.Tests
{
    [TestClass()]
    public class SortedSquaresTests
    {
        [TestMethod()]

        public void SolutionTest1()
        {
            int[] question = { -4, -1, 0, 3, 10 };
            int[] correct = { 0, 1, 9, 16, 100 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        public void SolutionTest2()
        {
            int[] question = { -7, -3, 2, 3, 11 };
            int[] correct = { 4, 9, 9, 49, 121 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        private bool checkSolution(int[] question, int[] correct) {
            int[] answer = SortedSquares.Solution(question);
            for (int i = 0; i < correct.Length; i++) {
                if (correct[i] != answer[i]) return false;
            }
            return true;
        }
    }
}