using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1346_CheckIfNAndItsDoubleExits;

namespace _1346_CheckIfNAndItsDoubleExits.Tests
{
    [TestClass()]
    public class CheckIfExitsTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] question = { 10, 2, 5, 3 };
            Assert.IsTrue(CheckIfExits.Solution(question));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[] question = { 3,1,7,11 };
            Assert.IsFalse(CheckIfExits.Solution(question));
        }
    }
}