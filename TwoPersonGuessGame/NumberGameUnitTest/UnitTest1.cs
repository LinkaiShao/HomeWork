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
    /// This big ting tests
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Big man
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            NumberGameThing.Program.NumberGame();
        }
    }
}
