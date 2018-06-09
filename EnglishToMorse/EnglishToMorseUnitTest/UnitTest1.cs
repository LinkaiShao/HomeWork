//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="Linkai">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace UnitTestProject1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using EnglishToMorse;

    /// <summary>
    /// The unit test class
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test if the results are actually the correct morse code
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            string ans = ".--...-.-.-..";
            Assert.AreEqual(EnglishToMorse.Program.Convert("abcd"), ans);
        }

        /// <summary>
        /// Test if damn turns into the right morse code
        /// </summary>
        public void TestMethod2()
        {
            Assert.AreEqual(EnglishToMorse.Program.Convert("damn"), "-...- -- -.");
        }

        public void TestMethod3()
        {
            Assert.AreEqual(EnglishToMorse.Program.Convert("bruh you gay"), "-....-...-..../-.-----..-/--..--.--");
        }

    }
}
