//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace WordCounterUnitTest
{
    using System.Collections.Generic;
    using System;
    using WordCounter;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The UnitTestClass
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test for word counter in normal circumstances
        /// </summary>
        [TestMethod]
        public void TestForWordCounter()
        {
            Assert.AreEqual(4, WordCounter.Program.WordCounter("Hi i am J"));
        }

        /// <summary>
        /// The test for word counter when the given string is emptt
        /// </summary>
        [TestMethod]
        public void WordCounterNullTest()
        {
            Assert.AreEqual(0, WordCounter.Program.WordCounter(string.Empty));
        }

        /// <summary>
        /// Test For count words in normal circumstances
        /// </summary>
        [TestMethod]
        public void TestForCountWords()
        {
            Assert.AreEqual(2, WordCounter.Program.CountWords("Hi i am j j")["j"]);   
        }
    }
}
