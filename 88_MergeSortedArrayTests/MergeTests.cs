using Microsoft.VisualStudio.TestTools.UnitTesting;
using _88_MergeSortedArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88_MergeSortedArray.Tests
{
    [TestClass()]
    public class MergeTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;

            int[] correct = { 1, 2, 2, 3, 5, 6 };

            Merge.Solution(nums1, m, nums2, n);
            Assert.IsTrue(checkSolution(nums1,correct));
        }
        [TestMethod()]
public void SolutionTest2()
        {
            int[] nums1 = { 1 };
            int m = 1;
            int[] nums2 = {};
            int n = 0;

            int[] correct = { 1 };

            Merge.Solution(nums1, m, nums2, n);
            Assert.IsTrue(checkSolution(nums1, correct));
        }
        [TestMethod()]
        public void SolutionTest3()
        {
            int[] nums1 = { 0 };
            int m = 0;
            int[] nums2 = { 1 };
            int n = 1;

            int[] correct = { 1 };

            Merge.Solution(nums1, m, nums2, n);
            Assert.IsTrue(checkSolution(nums1, correct));
        }
        private bool checkSolution(int[] nums1, int[] correct) {
            for (int i=0; i < nums1.Length; i++)
            {
                if (nums1[i] != correct[i]) return false;
            }
            return true;
        }
    }
}