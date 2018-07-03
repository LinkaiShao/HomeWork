//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace TestCastelMove
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CastelMove;

    /// <summary>
    /// Unit Test class
    /// </summary>
    [TestClass]
    public class UnitTest1
    {  
        /// <summary>
        /// Starting position
        /// </summary>
        private CastelMove.Position current = new CastelMove.Position();

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

        /// <summary>
        /// Test if horizontally it would work
        /// </summary>
        [TestMethod]
        public void TestMethodIfHorizontalWork()
        {
            this.current.X = 6;
            this.current.Y = 0;
            CastelMove.Position destination = new CastelMove.Position();
            
            destination.Y = 0;
            for (int i = 1; i < 5; i++)
            {
                destination.X = i;
                Assert.AreEqual(CastelMove.Program.VerifyCastelMovement(this.board, this.current, destination), true);
            }

            this.current.X = 1;
            this.current.Y = 5;
            destination.Y = 5;
            for (int i = 2; i < 5; i++)
            {
                destination.X = i;
                Assert.AreEqual(CastelMove.Program.VerifyCastelMovement(this.board, this.current, destination), true);
            }

        }

        /// <summary>
        /// Test if vertical works
        /// </summary>
        [TestMethod]
        public void TestMethodIfVerticalWork2()
        {
            this.current.X = 6;
            this.current.Y = 0;
            CastelMove.Position destination = new CastelMove.Position();
            destination.X = 1;
            for (int i = 0; i < 5; i++)
            { 
                destination.Y = i;
                this.current.Y = i;
                Assert.AreEqual(CastelMove.Program.VerifyCastelMovement(this.board, this.current, destination), true);
            }

            this.current.X = 0;
            for (int i = 1; i < 5; i++)
            {
                destination.Y = i;
                this.current.Y = i;
                Assert.AreEqual(CastelMove.Program.VerifyCastelMovement(this.board, this.current, destination), true);
            }
        }

        /// <summary>
        /// Test when scenarios such as when the position cannot be reached
        /// </summary>
        [TestMethod]
        public void TestMethodIfVerticalNotWork()
        {
            this.current.X = 6;
            CastelMove.Position destination = new CastelMove.Position();
            destination.X = 0;
            for (int i = 0; i < 5; i++)
            {
                destination.Y = i;
                this.current.Y = i;
                Assert.AreEqual(CastelMove.Program.VerifyCastelMovement(this.board, this.current, destination), false);
            }

            this.current.X = 1;
            for(int i = 0; i < 5; i++)
            {
                destination.Y = i;
                this.current.Y = i+1;
                Assert.AreEqual(CastelMove.Program.VerifyCastelMovement(this.board, this.current, destination), false);
            }
        }

        /// <summary>
        /// Test if horizontally positions cannot be reached
        /// </summary>
        [TestMethod]
        public void TestMethodIfHorizontalNotWork2()
        {
            this.current.Y = 0;
            this.current.X = 0;
            CastelMove.Position destination = new CastelMove.Position();
            destination.X = 0;
            for (int i = 2; i < 5; i++)
            {
                destination.Y = i;
                Assert.AreEqual(CastelMove.Program.VerifyCastelMovement(this.board, this.current, destination), false);
            }
        }

        /// <summary>
        /// Test if when the spot is diagonal the function returns false
        /// </summary>
        [TestMethod]
        public void TestMethodIfDiagonal()
        {
            CastelMove.Position destination = new CastelMove.Position();
            this.current.X = 5;
            this.current.Y = 0;
            for(int i = 1; i < 3; i++)
            {
                destination.X = this.current.X - i;
                destination.Y = this.current.Y + i;
                Assert.AreEqual(CastelMove.Program.VerifyCastelMovement(this.board, this.current, destination), false);
            }

        }

        /// <summary>
        /// Test if the when the destination or starting position is out of the board, it would return false
        /// </summary>
        [TestMethod]
        public void TestMethodIfOutofBounds()
        {
            CastelMove.Position destination = new CastelMove.Position();
            destination.X = 100;
            destination.Y = 100;
            this.current.X = 0;
            this.current.Y = 0;
            Assert.AreEqual(CastelMove.Program.VerifyCastelMovement(this.board, this.current, destination), false);
            this.current.X = 100;
            this.current.Y = 100;
            destination.X = 0;
            destination.Y = 0;
            Assert.AreEqual(CastelMove.Program.VerifyCastelMovement(this.board, this.current, destination), false);
        }
    }
}
