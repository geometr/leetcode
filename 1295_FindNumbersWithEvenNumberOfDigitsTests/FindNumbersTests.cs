using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1295_FindNumbersWithEvenNumberOfDigits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1295_FindNumbersWithEvenNumberOfDigits.Tests
{
    [TestClass()]
    public class FindNumbersTests
    {

        [TestMethod()]
        public void SolutionTest1()
        {
            int[] question = { 12, 345, 2, 6, 7896 };
            int correct = 2;
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[] question = { 555, 901, 482, 1771 };
            int correct = 1;
            Assert.IsTrue(checkSolution(question, correct));
        }

        private bool checkSolution(int[] question, int correct) {
            int answer = FindNumbers.Solution(question);
            if (correct == answer) return true;
            return false;
        }
    }
}