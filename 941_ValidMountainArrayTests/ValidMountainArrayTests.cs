using Microsoft.VisualStudio.TestTools.UnitTesting;
using _941_ValidMountainArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _941_ValidMountainArray.Tests
{
    [TestClass()]
    public class ValidMountainArrayTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] question = {2,1};
            Assert.IsFalse(ValidMountainArray.Solution(question));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[] question = { 3, 5, 5};
            Assert.IsFalse(ValidMountainArray.Solution(question));
        }
        [TestMethod()]
        public void SolutionTest3()
        {
            int[] question = { 0, 3, 2, 1 };
            Assert.IsTrue(ValidMountainArray.Solution(question));
        }
        [TestMethod()]
        public void SolutionTest4()
        {
            int[] question = { 2,0,2 };
            Assert.IsFalse(ValidMountainArray.Solution(question));
        }
        [TestMethod()]
        public void SolutionTest5()
        {
            int[] question = {0,1,2,1,2 };
            Assert.IsFalse(ValidMountainArray.Solution(question));
        }
    }
}