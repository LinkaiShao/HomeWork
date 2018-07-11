using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _24Points2; 
namespace _24pointsTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestIfContainspossibleNums()
        {
            Dictionary<string, char[]> testDict = _24Points2.Program.GetAllCombos();
            string[] testIntegers = new string[]
            {
                "2223",
                "2224",
                "1243",
                "9444",
                "7773",
                "6666",
                "5554"
            };

            for(int i = 0; i < testIntegers.Length; i++)
            {
                Assert.AreEqual(true, testDict.ContainsKey(testIntegers[i]));
            }
            
            

        }

        [TestMethod]
        public void TestIfResultIs24 ()
        {
            Dictionary<string, char[]> testDict = _24Points2.Program.GetAllCombos();
            string[] testIntegers = new string[]
            {
                "2223",
                "2224",
                "1243",
                "9444",
                "7773",
                "6666",
                "5554"
            };
            for (int i = 0; i < testIntegers.Length; i++)
            {
                int result1 = 0;
                int result2 = 0;
                int result3 = 0;
                result1 = _24Points2.Program.Math(Convert.ToInt32(testIntegers[i][0]), Convert.ToInt32(testIntegers[i][1]), _24Points2.Program.IdentifySign(testDict[testIntegers[i]][0]));
                result2 = _24Points2.Program.Math(result1, Convert.ToInt32(testIntegers[i][2]),_24Points2.Program.IdentifySign( testDict[testIntegers[i]][1]));
                result3 = _24Points2.Program.Math(result2, Convert.ToInt32(testIntegers[i][3]), _24Points2.Program.IdentifySign(testDict[testIntegers[i]][2]));
                Assert.AreEqual(24, result3);
            }
        }
        
    }
}
