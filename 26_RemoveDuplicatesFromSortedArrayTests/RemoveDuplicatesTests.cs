using Microsoft.VisualStudio.TestTools.UnitTesting;
using _26_RemoveDuplicatesFromSortedArray;


namespace _26_RemoveDuplicatesFromSortedArray.Tests
{
    [TestClass()]
    public class RemoveDuplicatesTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] question = { 1, 1, 2 };
            int correct = 2;
            int[] correctArr = { 1, 2 };
            Assert.IsTrue(checkSolution(question, correct, correctArr));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[] question = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int correct = 5;
            int[] correctArr = { 0, 1, 2, 3, 4 };
            Assert.IsTrue(checkSolution(question, correct, correctArr));
        }
        private bool checkSolution(int[] question, int correct, int[] correctArr) {
            int answer = RemoveDuplicates.Solution(question);
            if (answer != correct) return false;
            for (int i = 0; i < correctArr.Length; i++)
            {
                if (question[i] != correctArr[i]) return false;
            };

            return true;
        }
    }
}