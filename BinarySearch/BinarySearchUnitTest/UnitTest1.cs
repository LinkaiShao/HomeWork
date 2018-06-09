//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace UnitTestProject1
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BinaryThing;

    /// <summary>
    /// The Unit Test class
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test if the binary search is correct under different conditions
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 11, 12 };
            Assert.AreEqual(BinaryThing.Program.BinarySearch(numbers, 10), -1);
            Assert.AreEqual(BinaryThing.Program.BinarySearch(numbers, 2), 1);
            Assert.AreEqual(BinaryThing.Program.BinarySearch(numbers, 4), 3);
            Assert.AreEqual(BinaryThing.Program.BinarySearch(numbers, 11), 10);
            Assert.AreEqual(BinaryThing.Program.BinarySearch(numbers, 13), -1);
        }
    }
}
