using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1051_HeightChecker;


namespace _1051_HeightChecker.Tests
{
    [TestClass()]
    public class HeightCheckerTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] question = { 1, 1, 4, 2, 1, 3 };
            int correct = 3;
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[] question = { 5,1,2,3,4 };
            int correct = 5;
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest3()
        {
            int[] question = { 1,2,3,4,5 };
            int correct = 0;
            Assert.IsTrue(checkSolution(question, correct));
        }
        private bool checkSolution(int[] question, int correct){
            int answer = HeightChecker.Solution(question);
            if (answer == correct) return true;
            return false;
        }
    }
}