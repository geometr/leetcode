using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1299_ReplaceElementsWithGreatestElementOnRightSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1299_ReplaceElementsWithGreatestElementOnRightSide.Tests
{
    [TestClass()]
    public class ReplaceElementsTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] question = { 17, 18, 5, 4, 6, 1 };
            int[] correct = { 18, 6, 6, 6, 1, -1 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[] question = { 400 };
            int[] correct = { -1 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        private bool checkSolution(int[] question, int[] correct)
        {
            int[] answer = ReplaceElements.Solution(question);
            if (answer.Length == 0) return false;
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] != correct[i]) return false;
            }
            return true;
        }
    }
}