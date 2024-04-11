using Microsoft.VisualStudio.TestTools.UnitTesting;
using _66_PlusOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_PlusOne.Tests
{
    [TestClass()]
    public class PlusOneTests
    {
        [TestMethod()]
        public void PlusOneTest1()
        {
            int[] question = { 1, 2, 3 };
            int[] correct = { 1, 2, 4 };
            Assert.IsTrue(checkSolution(question,correct));
        }
        [TestMethod()]
        public void PlusOneTest2()
        {
            int[] question = { 4,3,2,1 };
            int[] correct = { 4,3,2,2 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void PlusOneTest3()
        {
            int[] question = { 9 };
            int[] correct = { 1,0 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void PlusOneTest4()
        {
            int[] question = { 0 };
            int[] correct = { 1 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        private bool checkSolution(int[] question,int[] correct) {
            int[] answer = PlusOne.Solution(question);
            for(int i = 0; i < correct.Length; i++)
            {
                if (answer[i] != correct[i]) return false;
            }
            return true;
        }
    }
}