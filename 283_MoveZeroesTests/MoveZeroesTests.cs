using Microsoft.VisualStudio.TestTools.UnitTesting;
using _283_MoveZeroes;

namespace _283_MoveZeroes.Tests
{
    [TestClass()]
    public class MoveZeroesTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] question = { 0, 1, 0, 3, 12 };
            int[] correct = { 1,3,12,0,0};
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[] question = { 0};
            int[] correct = {0 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest3()
        {
            int[] question = { 0,1 };
            int[] correct = { 1,0 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        private bool checkSolution(int[] question, int[] correct) {
            MoveZeroes.Solution(question);
            for (int i = 0; i < question.Length; i++)
            {
                if (correct[i] != question[i]) return false;
            }
            return true;
        }
    }
}