using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1089_DuplicateZeros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1089_DuplicateZeros.Tests
{
    [TestClass()]
    public class DuplicateZerosTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] question = { 1,0,2,3,0,4,5,0 };
            int[] correct = {1,0,0,2,3,0,0,4 };
            Assert.IsTrue(checkSolution(question,correct));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[] question = { 1, 2, 3 };
            int[] correct = { 1, 2, 3 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        private bool checkSolution(int[] question, int[] correct) {
            int[] answer= new int[question.Length];
            Array.Copy(question, 0, answer, 0, question.Length);
            DuplicateZeros.Solution(answer);
            for (int i = 0; i < answer.Length; i++) {
                if (answer[i] != correct[i]) return false;
            }
            return true;
        }
    }
}