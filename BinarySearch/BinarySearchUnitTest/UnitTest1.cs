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
    /// Does testing
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test if the binary search is correct
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 11, 12 };
            Assert.AreEqual(BinaryThing.Program.BinarySearch(numbers, 10), -1);
        }
    }
}
