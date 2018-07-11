//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ZigZagTest
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ZigZag;

    /// <summary>
    /// The unit test class 
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test when either the maximum number is zero or when the limitation is zero
        /// </summary>
        [TestMethod]
        public void TestWhenZero()
        {
            List<List<int>> result = ZigZag.Program.ZigZag(0, 10);
            Assert.IsTrue(result.Count == 0);
            result = ZigZag.Program.ZigZag(10, 0);
            Assert.IsTrue(result.Count == 0);
        }

        /// <summary>
        /// Test if the numbers of the ending list are ordered correctly
        /// </summary>
        [TestMethod]
        public void TestIfRightNumbers()
        {
            List<List<int>> result = ZigZag.Program.ZigZag(100, 10);
            for (int i = 0; i < result.Count; i++)
            {
                if (i == 0 || i % 2 == 0)
                {
                    for (int j = 0; j < result[j].Count - 1; j++)
                    {
                        Assert.IsTrue(result[i][j] + 1 == result[i][j + 1]);
                    }
                }
                else
                {
                    for (int j = 0; j < result[j].Count - 1; j++)
                    {
                        Assert.IsTrue(result[i][j] - 1 == result[i][j + 1]);
                    }
                }
            }  
        }

        /// <summary>
        /// Test if starting number and ending numbers are correct 
        /// </summary>
        [TestMethod]
        public void TestIfRightLastNum()
        {
            List<List<int>> result = ZigZag.Program.ZigZag(100, 10);
            Assert.AreEqual(1, result[0][0]);
            Assert.AreEqual(100, result[result.Count - 1][0]);
        }
    }
}
