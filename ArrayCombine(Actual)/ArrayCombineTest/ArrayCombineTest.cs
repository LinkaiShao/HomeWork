//-----------------------------------------------------------------------
// <copyright file="ArrayCombineTest.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ArrayCombineTest
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
  
    /// <summary>
    /// The array combine test class
    /// </summary>
    [TestClass]
    public class ArrayCombineTest
    {
        /// <summary>
        /// Test the time that it takes for each method to run 10000 times
        /// </summary>
        /// <param name="array1"> first input </param>
        /// <param name="array2"> second input </param>
        /// <param name="method"> the number represents the method of combining arrays </param>
        /// <returns> times spent </returns>
        public static TimeSpan TestTime(int[] array1, int[] array2, int method)
        {

            DateTime before;
            DateTime after;
            TimeSpan time;
            before = DateTime.Now;
            if (method == 1)
            {
                for (int i = 0; i < 10000; i++)
                {
                    int[] array10 = ArrayCombine.Program.CombineArray(array1, array2);
                }
            }
            else if (method == 2)
            {
                for (int i = 0; i < 10000; i++)
                {
                    int[] array10 = ArrayCombine.Program.CombineArray2(array1, array2);
                }
            }
            else
            {
                for (int i = 0; i < 10000; i++)
                {
                    int[] array10 = ArrayCombine.Program.CombineArray3(array1, array2);
                }
            }

            after = DateTime.Now;
            time = after.Subtract(before);
            return time;
        }

        /// <summary>
        /// tests if the combined arrays have the same content and if they are sorted
        /// </summary>
        [TestMethod]
        public void TestArrayCombine()
        {
            List<int> array4 = new List<int> { 5, 7, 23, 4, 41, 42, 5, 61, 24, 21, 5, 512, 7, 4 };
            List<int> array5 = new List<int> { 3, 2, 72, 82, 72, 4, 7, 72, 47, 72 };
            array4.Sort();
            array5.Sort();
            int[] array1 = array4.ToArray();
            int[] array2 = array5.ToArray();
            
            int[] array3 = ArrayCombine.Program.CombineArray3(array1, array2);
            TimeSpan time = TestTime(array1, array2, 1);
            TimeSpan time2 = TestTime(array1, array2, 2);
            TimeSpan time3 = TestTime(array1, array2, 3);

            for (int i = 0; i < array3.Length - 1; i++)
            {
                if (array3[i] < array3[i + 1] || array3[i] == array3[i + 1])
                {
                    Assert.AreEqual(true, true);
                }
                else
                {
                    Assert.AreEqual(true, false);
                }
            }
//// See if the final array contains everything from both initial arrays
            bool contains = false;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array3.Length; j++)
                {
                    if (array3[j] == array1[i])
                    {
                        contains = true;
                    }
                }

                Assert.AreEqual(true, contains);
                contains = false;
            }

            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array3.Length; j++)
                {
                    if (array3[j] == array2[i])
                    {
                        contains = true;
                    }
                }

                Assert.AreEqual(true, contains);
                contains = false;
            }
        }

        /// <summary>
        /// Test if when the provided arrays are empty, the combined array would be empty
        /// </summary>
        [TestMethod]
        public void TestIfArraysEmpty()
        {
            int[] array1 = new int[] { };
            int[] array2 = new int[] { };
            int[] array3 = ArrayCombine.Program.CombineArray3(array1, array2);
            Assert.AreEqual(0, array3.Length);
            array2 = new int[] { 1, 2, 3, 4 };
            array3 = ArrayCombine.Program.CombineArray3(array1, array2);
            Assert.AreEqual(4, array3.Length);
            array2 = new int[] { };
            array1 = new int[] { 1, 2, 3, 4 };
            array3 = ArrayCombine.Program.CombineArray3(array1, array2);
            Assert.AreEqual(4, array3.Length);
        }
    }
}
