//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace UnitTestProject1
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NumberGameThing;

    /// <summary>
    /// The Unit Test class
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests the function of number game
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            NumberGameThing.Program.NumberGame();
        }
    }
}
