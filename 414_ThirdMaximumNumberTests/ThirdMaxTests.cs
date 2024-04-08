using Microsoft.VisualStudio.TestTools.UnitTesting;
using _414_ThirdMaximumNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _414_ThirdMaximumNumber.Tests
{
    [TestClass()]
    public class ThirdMaxTests
    {

        [TestMethod()]
        public void SolutionTest1()
        {
            int[] question = { 2, 2, 3, 1 };
            int correct = 1;
            Assert.IsTrue(checkSolution(question, correct));
        }

        [TestMethod()]
        public void SolutionTest2()
        {
            int[] question = { 1, 2 };
            int correct = 2;
            Assert.IsTrue(checkSolution(question, correct));
        }

        [TestMethod()]
        public void SolutionTest3()
        {
            int[] question = { 3, 2, 1 };
            int correct = 1;
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest4()
        {
            int[] question = { 1, 1, 2 };
            int correct = 2;
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest5()
        {
            int[] question = { 5,2,2 };
            int correct = 5;
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest6()
        {
            int[] question = { 14 };
            int correct = 14;
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest7()
        {
            int[] question = {1,2,2,5,3,5};
            int correct = 2;
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest8()
        {
            int[] question = {1,-2147483648,2};
            int correct = -2147483648;
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest9()
        {
            int[] question = { 15, 2, 4, 1, 3, 6, 0 };
            int correct = 4;
            Assert.IsTrue(checkSolution(question, correct));
        }
        private bool checkSolution(int[] question, int correct) {
            int answer = ThirdMax.Solution(question);
            if (answer == correct) return true;
            return false;
        }
    }
}