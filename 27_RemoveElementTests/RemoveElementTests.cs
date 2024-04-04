using Microsoft.VisualStudio.TestTools.UnitTesting;
using _27_RemoveElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_RemoveElement.Tests
{
    [TestClass()]
    public class RemoveElementTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            int[] correctNums = {2,2};
         
            int answerCorrect = 2;
            Assert.IsTrue(checkSolution(nums,val,correctNums,answerCorrect));
        }
        
   [TestMethod()]   
        public void SolutionTest2()
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;
            int[] correctNums = { 0, 1, 3, 0, 4 };
            
            int answerCorrect = 5;
            Assert.IsTrue(checkSolution(nums, val, correctNums, answerCorrect));
        }
        private bool checkSolution(int[] nums, int val, int[] correctNums, int answerCorrect) {
            int answer = RemoveElement.Solution(nums, val);
            if (answer != answerCorrect) return false;
         
            for(int i = 0; i < correctNums.Length; i++)
            {
                if (nums[i] != correctNums[i]) return false;
            }
            return true; 
        }
    }
}