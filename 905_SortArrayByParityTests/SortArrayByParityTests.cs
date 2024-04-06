using Microsoft.VisualStudio.TestTools.UnitTesting;
using _905_SortArrayByParity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _905_SortArrayByParity.Tests
{
    [TestClass()]
    public class SortArrayByParityTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] question = { 3, 1, 2, 4 };
            int[] correct = { 4, 2, 1, 3 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[] question = { 0 };
            int[] correct = { 0 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        private bool checkSolution(int[] question, int[] correct) {
            int[] answer = SortArrayByParity.Solution(question);
            if (answer.Length != correct.Length) return false;
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] != correct[i]) return false;
            }
            return true;
        }
    }
}