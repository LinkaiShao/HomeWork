//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="Linkai">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace UnitTestProject1
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using EnglishToSamuel;

    /// <summary>
    /// Tests shit
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test if the result is correct
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(EnglishToSamuel.Program.Convert("abcd"), ".--...-.-.-..");
        }
    }
}
