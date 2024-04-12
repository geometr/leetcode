using Microsoft.VisualStudio.TestTools.UnitTesting;
using _498_FindDiagonalOrder;

namespace _498_FindDiagonalOrder.Tests
{
    [TestClass()]
    public class FindDiagonalOrderTests
    {
        [TestMethod()]
        public void SolutionTest1()
        {
            int[][] question = new int[3][];
            question[0] = new int[] { 1, 2, 3};
            question[1] = new int[] { 4, 5, 6};
            question[2] = new int[] { 7, 8, 9};
            int[] correct = { 1, 2, 4, 7, 5, 3, 6, 8, 9 };
            Assert.IsTrue(checkSolution(question,correct));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            int[][] question = new int[2][];
            question[0] = new int[] { 1, 2};
            question[1] = new int[] { 3, 4};
            int[] correct = { 1, 2, 3, 4};
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest3()
        {
            int[][] question = new int[3][];
            question[0] = new int[] { 2, 5 };
            question[1] = new int[] { 8, 4 };
            question[2] = new int[] { 0, -1 };
            int[] correct = { 2,5,8,0,4,-1 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest4()
        {
            int[][] question = new int[2][];
            question[0] = new int[] { 3 };
            question[1] = new int[] { 2 };
            
            int[] correct = { 3,2 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest5()
        {
            int[][] question = new int[2][];
            question[0] = new int[] { 2,5,8 };
            question[1] = new int[] { 4,0,-1 };

            int[] correct = { 2,5,4,0,8,-1 };
            Assert.IsTrue(checkSolution(question, correct));
        }
        [TestMethod()]
        public void SolutionTest6()
        {
            int[][] question = new int[1][];
            question[0] = new int[] { 1,2,3,4,5,6,7,8,9,10 };
            

            int[] correct = { 1,2,3,4,5,6,7,8,9,10};
            Assert.IsTrue(checkSolution(question, correct));
        }


        private bool checkSolution(int[][] question, int[] correct)
        {
            int[] answer = FindDiagonalOrder.Solution(question);
            if (answer.Length != correct.Length) return false;
            for (int i = 0; i< answer.Length; i++)
            {
                if (answer[i] != correct[i]) return false;
            }
            return true;
        }
    }
}