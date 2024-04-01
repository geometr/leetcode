using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace _01_TwoSum.Tests
{
    [TestClass()]
    public class TwoSumTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] correct = { 0, 1 };
            
            checkSolution(nums, target, correct);
        }

        [TestMethod()]
        public void SolutionTest2()
        {
            int[] nums = { 3, 2, 4};
            int target = 6;
            int[] correct = { 1, 2 };

            checkSolution(nums, target, correct);
        }

        [TestMethod()]
        public void SolutionTest3()
        {
            int[] nums = { 3, 3 };
            int target = 6;
            int[] correct = { 0, 1 };

            checkSolution(nums, target, correct);
        }
        [TestMethod()]
        public void SolutionTest4()
        {
            int[] nums = { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            int target = 11;
            int[] correct = { 5, 11 };

            checkSolution(nums, target, correct);
        }

        void checkSolution(int[] nums, int target, int[] correct)
        {
            int[] result = TwoSum.Solution(nums, target);
            Assert.IsTrue((result[0] == correct[0]) && (result[1] == correct[1]));
        }
    }
}