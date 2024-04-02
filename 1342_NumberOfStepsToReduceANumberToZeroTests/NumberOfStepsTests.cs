using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1342_NumberOfStepsToReduceANumberToZero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1342_NumberOfStepsToReduceANumberToZero.Tests
{
    [TestClass()]
    public class NumberOfStepsTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int question = 14;
            int correct = 6;
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int question = 8;
            int correct = 4;
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest3()
        {
            int question = 123;
            int correct = 12;
            Assert.IsTrue(checkSolution(question, correct));
        }
        private Boolean checkSolution(int question, int correct)
        {
            int answer = NumberOfSteps.Solution(question);
            return answer == correct;
        }
    }
}