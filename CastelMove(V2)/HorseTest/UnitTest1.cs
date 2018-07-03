using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CastelMove_V2_;

namespace HorseTest
{
    
   
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// The testing board 
        /// </summary>
        private int[][] board = new int[][]
        {
           new int[] { 2, 2, 2, 2, 2, 2, 2 },
           new int[] { 2, 2, 2, 2, 2, 2, 2 },
           new int[] { 0, 0, 0, 0, 0, 0, 0 },
           new int[] { 0, 0, 0, 0, 0, 0, 0 },
           new int[] { 0, 0, 0, 0, 0, 0, 0 },
           new int[] { 0, 0, 0, 0, 0, 0, 0 },
           new int[] { 1, 1, 1, 1, 1, 1, 1 }
        };

        private int[][] board2 = new int[][]
        {
           new int[] { 2, 2, 2, 2, 2, 2, 2 },
           new int[] { 2, 2, 2, 2, 2, 2, 2 },
           new int[] { 0, 0, 0, 1, 0, 0, 0 },
           new int[] { 0, 0, 1, 0, 1, 0, 0 },
           new int[] { 0, 0, 0, 1, 0, 0, 0 },
           new int[] { 0, 0, 0, 0, 0, 0, 0 },
           new int[] { 1, 1, 1, 1, 1, 1, 1 }
        };

        private int[][] board3 = new int[][]
       {
           new int[] { 2, 2, 2, 2, 2, 2, 2 },
           new int[] { 2, 2, 2, 2, 2, 2, 2 },
           new int[] { 0, 1, 1, 1, 1, 1, 0 },
           new int[] { 0, 1, 1, 0, 1, 1, 0 },
           new int[] { 0, 1, 1, 1, 1, 1, 0 },
           new int[] { 0, 1, 1, 1, 1, 1, 0 },
           new int[] { 1, 1, 1, 1, 1, 1, 1 }
       };

        /// <summary>
        /// Starting position
        /// </summary>
        private CastelMove_V2_.Position current = new CastelMove_V2_.Position();

        [TestMethod]
        public void TestHorseIfWork()
        {
            current.X = 4;
            current.Y = 3;
            CastelMove_V2_.Position destination = new CastelMove_V2_.Position();
            destination.X = current.X + 1;
            destination.Y = current.Y + 2;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board, current, destination), true);
            destination.X = current.X + 1;
            destination.Y = current.Y - 2;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board, current, destination), true);
            destination.X = current.X -1;
            destination.Y = current.Y +2;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board, current, destination), true);
            destination.X = current.X - 1;
            destination.Y = current.Y - 2;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board, current, destination), true);
            destination.X = current.X - 2;
            destination.Y = current.Y - 1;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board, current, destination), true);
            destination.X = current.X - 2;
            destination.Y = current.Y + 1;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board, current, destination), true);
            current.X = 3;
            destination.X = current.X + 2;
            destination.Y = current.Y + 1;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board, current, destination), true);
            destination.X = current.X + 2;
            destination.Y = current.Y - 1;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board, current, destination), true);

        }

        [TestMethod]
        public void TestIfBlocked()
        {
            current.X = 3;
            current.Y = 3;
            CastelMove_V2_.Position destination = new CastelMove_V2_.Position();
            destination.X = current.X - 1;
            destination.Y = current.Y + 2;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board2, current, destination), false);
            destination.X = current.X - 1;
            destination.Y = current.Y - 2;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board2, current, destination), false);
            destination.X = current.X + 1;
            destination.Y = current.Y - 2;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board2, current, destination), false);
            destination.X = current.X + 1;
            destination.Y = current.Y + 2;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board2, current, destination), false);

        }

        [TestMethod]
        public void IfDestinationIsAllie()
        {
            current.X = 4;
            current.Y = 3;
            CastelMove_V2_.Position destination = new CastelMove_V2_.Position();
            destination.X = current.X + 1;
            destination.Y = current.Y + 2;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board3, current, destination), false);
            destination.X = current.X + 1;
            destination.Y = current.Y - 2;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board3, current, destination), false);
            destination.X = current.X - 1;
            destination.Y = current.Y + 2;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board3, current, destination), false);
            destination.X = current.X - 1;
            destination.Y = current.Y - 2;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board3, current, destination), false);
            destination.X = current.X - 2;
            destination.Y = current.Y - 1;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board3, current, destination), false);
            destination.X = current.X - 2;
            destination.Y = current.Y + 1;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board3, current, destination), false);
            current.X = 3;
            destination.X = current.X + 2;
            destination.Y = current.Y + 1;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board3, current, destination), false);
            destination.X = current.X + 2;
            destination.Y = current.Y - 1;
            Assert.AreEqual(CastelMove_V2_.Program.HorseMove(this.board3, current, destination), false);
        }

       
    }
}
