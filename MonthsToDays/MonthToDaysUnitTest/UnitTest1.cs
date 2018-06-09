//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="Linkai">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace UnitTestProject1
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MonthToDays;

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
            Assert.AreEqual(MonthToDays.Program.MonthDays(3), 31);
            Assert.AreEqual(MonthToDays.Program.MonthDays2(11), 30);
        }
    }
}
