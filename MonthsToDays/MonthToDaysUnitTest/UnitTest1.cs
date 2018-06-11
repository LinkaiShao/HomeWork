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
        public void TestAllDays()
        {
            int[] months = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (int i=1; i <= 12; i++)
            {
                Assert.AreEqual(months[i], MonthToDays.Program.MonthDays(3));
            }
        }

        [TestMethod]
        public void TestMethodOutOfRange()
        {
            
            Assert.AreEqual(-1, MonthToDays.Program.MonthDays(13));
            
        }

        [TestMethod]
        public void TestMethodOutOfRange2()
        {
           
            Assert.AreEqual(-1, MonthToDays.Program.MonthDays(0));
        }
    }
}
