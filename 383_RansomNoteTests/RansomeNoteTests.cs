using Microsoft.VisualStudio.TestTools.UnitTesting;
using _383_RansomNote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383_RansomNote.Tests
{
    [TestClass()]
    public class RansomeNoteTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            string ransomeNote = "a";
            string magazine = "b";

            bool correct = false;

            Assert.IsTrue(checkSolution(ransomeNote, magazine, correct));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            string ransomeNote = "aa";
            string magazine = "ab";

            bool correct = false;

            Assert.IsTrue(checkSolution(ransomeNote, magazine, correct));
        }
        [TestMethod()]
        public void SolutionTest3()
        {
            string ransomeNote = "aa";
            string magazine = "aab";

            bool correct = true;

            Assert.IsTrue(checkSolution(ransomeNote, magazine, correct));
        }
        private bool checkSolution(string ransomeNote, string magazine, bool correct) {
            if (RansomeNote.Solution(ransomeNote, magazine) == correct) return true;
            return false;
        }
    }
}