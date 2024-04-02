using Microsoft.VisualStudio.TestTools.UnitTesting;
using _412_FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _412_FizzBuzz.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int question = 3;
            List<string> correct = new List<string>() { "1", "2", "Fizz" };

            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int question = 5;
            List<string> correct = new List<string>() { "1", "2", "Fizz", "4", "Buzz" };

            Assert.IsTrue(checkSolution(question, correct));
        }

        [TestMethod()]
        public void SolutionTest3()
        {
            int question = 15;
            List<string> correct = new List<string>() { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            Assert.IsTrue(checkSolution(question, correct));
        }
        private Boolean checkSolution(int question, IList<string> correct) {
            IList<string> answer = FizzBuzz.Solution(question);
            for (int i = 0; i < answer.Count; i++) {
                if (!answer.ElementAt(i).Equals(correct.ElementAt(i))) return false;
            }
            return true;
        }
    }
}