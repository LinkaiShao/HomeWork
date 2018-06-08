//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="Linkai">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace UnitTestProject1
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Months_Ting;

    /// <summary>
    /// Me testing stuff
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test both functions in program.cs
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Months_Ting.Program.MonthDays(3), 31);
            Assert.AreEqual(Months_Ting.Program.MonthDays2(11), 30);
        }
    }
}
