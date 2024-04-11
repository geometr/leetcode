using Microsoft.VisualStudio.TestTools.UnitTesting;
using _747_LargestNumberAtLeastTwiceOfOther;
namespace _747_LargestNumberAtLeastTwiceOfOther.Tests
{
    [TestClass()]
    public class DominantIndexTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] nums = {3,6,1,0};
            int correct = 1;
            Assert.IsTrue(checkSolution(nums,correct));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[] nums = { 1,2,3,4 };
            int correct = -1;
            Assert.IsTrue(checkSolution(nums, correct));
        }
        [TestMethod()]
        public void SolutionTest3()
        {
            int[] nums = { 1, 0 };
            int correct = 0;
            Assert.IsTrue(checkSolution(nums, correct));
        }

        private bool checkSolution(int[] nums, int correct)
        {
            int answer = DominantIndex.Solution(nums);
            if (answer == correct) return true;
            return false;
        }
    }
}