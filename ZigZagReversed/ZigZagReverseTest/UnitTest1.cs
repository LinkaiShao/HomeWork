//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ZigZagReverseTest
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ZigZagReverseTest;

    /// <summary>
    /// Unit test class 
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test when the resulting data has no column with different number of variables than the others
        /// </summary>
        [TestMethod]
        public void WhenResultHasNoSpacing()
        {
            var output = new TestOutput();
            int difference = 0;
            ZigZagReversed.Program.ZigZagReverse(100, 10, output);
            for (int i = 0; i < output.Data.Count; i++)
            {
                for (int j = 0; j < output.Data[i].Count; j++)
                {
                    if (j == 0 || j % 2 == 0)
                    {
                        if (!((i + 1) > output.Data.Count - 1))
                        {
                            difference = output.Data[i + 1][j] - output.Data[i][j];
                            Assert.AreEqual(1, difference);
                        }  
                    }
                    else
                    {
                        if (!((i + 1) > output.Data.Count - 1))
                        {
                            difference = output.Data[i][j] - output.Data[i + 1][j];
                            Assert.AreEqual(1, difference);
                        }   
                    }
                }
            }

            List<int> allItems = new List<int>();
            foreach (var item in output.Data)
            {
                allItems.AddRange(item);
            }

            for (int i = 1; i < 100; i++)
            {
                Assert.IsTrue(allItems.Contains(i));
            }
        }

        /// <summary>
        /// Test when some columns of the data has more variables than others 
        /// </summary>
        [TestMethod]
        public void TestWhenResultHasSpacing()
        {
            var output = new TestOutput();
            ZigZagReversed.Program.ZigZagReverse(20, 6, output);
            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(1, output.Data[i + 1][0] - output.Data[i][0]);
                Assert.AreEqual(1, output.Data[i][1] - output.Data[i + 1][1]);
                Assert.AreEqual(1, output.Data[i + 1][2] - output.Data[i][2]);
            }

            Assert.AreEqual(1, output.Data[4][3] - output.Data[5][3]);
            List<int> allItems = new List<int>();
            foreach (var item in output.Data)
            {
                allItems.AddRange(item);
            }

            for (int i = 1; i < 20; i++)
            {
                Assert.IsTrue(allItems.Contains(i));
            }
        }

        /// <summary>
        /// Test when some parameters given are zero 
        /// </summary>
        [TestMethod]
        public void TestWhenZero()
        {
            var output = new TestOutput();
            ZigZagReversed.Program.ZigZagReverse(100, 0, output);
            Assert.AreEqual(0, output.Data.Count);
            ZigZagReversed.Program.ZigZagReverse(0, 0, output);
            Assert.AreEqual(0, output.Data.Count);
            ZigZagReversed.Program.ZigZagReverse(0, 10, output);
            Assert.AreEqual(0, output.Data.Count);
        }

        /// <summary>
        /// Test when some parameters given are zero 
        /// </summary>
        [TestMethod]
        public void TestWhenOne()
        {
            var output = new TestOutput();
            ZigZagReversed.Program.ZigZagReverse(1, 1, output);
            Assert.AreEqual(1, output.Data.Count);
            Assert.AreEqual(1, output.Data[0].Count);
            Assert.AreEqual(1, output.Data[0][0]);
        }
    }
}
