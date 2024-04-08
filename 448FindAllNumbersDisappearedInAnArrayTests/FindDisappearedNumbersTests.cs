using Microsoft.VisualStudio.TestTools.UnitTesting;
using _448FindAllNumbersDisappearedInAnArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _448FindAllNumbersDisappearedInAnArray.Tests
{
    [TestClass()]
    public class FindDisappearedNumbersTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[] question = { 4,3,2,7,8,2,3,1};
            IList<int> correct = new List<int> { 5,6 };
            Assert.IsTrue(checkSolution(question,correct));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[] question = { 1, 1};
            IList<int> correct = new List<int> { 2 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest3()
        {
            int[] question = { 4,3,2,7,8,2,3,1 };
            IList<int> correct = new List<int> { 5,6 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        private bool checkSolution(int[] question, IList<int> correct)
        {
            IList<int> answer = FindDisappearedNumbers.Solution(question);
            for (int i = 0; i < answer.Count; i++)
            {
                if (answer.ElementAt(i) != correct.ElementAt(i)) return false;
            }
            return true;
        }
    }
}