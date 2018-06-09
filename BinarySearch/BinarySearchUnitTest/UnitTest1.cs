//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace UnitTestProject1
{
    using System;
    using BinaryThing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void TestNumNotFound()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 11, 12 };
            Assert.AreEqual(BinaryThing.Program.BinarySearch(numbers, 10), -1);
        }

        /// <summary>
        /// Test it number after middle returns right result
        /// </summary>
        [TestMethod]
        public void TestNumInArray()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 11, 12 };
            for (var i = 0; i < numbers.Length; i++)
            {
                Assert.AreEqual(BinaryThing.Program.BinarySearch(numbers, numbers[i]), i);
            }
        }

        /// <summary>
        /// Test if when number is out of the array the function returns right answer
        /// </summary>
        [TestMethod]
        public void TestMethodNumOutOfRange()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 11, 12 };
            Assert.AreEqual(BinaryThing.Program.BinarySearch(numbers, 13), -1);
        }
    }
}
