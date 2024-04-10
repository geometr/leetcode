using Microsoft.VisualStudio.TestTools.UnitTesting;
using _724FindPivotIndex;

namespace _724FindPivotIndex.Tests
{
    [TestClass()]
    public class PivotIndexTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] nums = {1, 7, 3, 6, 5, 6 };
            int correct = 3;
            Assert.IsTrue(checkSolution(nums,correct));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[] nums = { 1,2,3 };
            int correct = -1;
            Assert.IsTrue(checkSolution(nums, correct));
        }
        [TestMethod()]
        public void SolutionTest3()
        {
            int[] nums = { 2,1,-1 };
            int correct = 0;
            Assert.IsTrue(checkSolution(nums, correct));
        }
        private bool checkSolution(int[] nums, int correct)
        {
            int answer = PivotIndex.Solution(nums);
            if (answer == correct) return true;
            return false;
        }
    }
}