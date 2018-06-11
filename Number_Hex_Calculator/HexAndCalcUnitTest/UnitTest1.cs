using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Number_Hex_Calculator;

namespace HexAndCalcUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HexTest()
        {
            for(int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++) {
                    for (int k = 1; k < 9; k++) {
                        Assert.AreEqual(((i * 16 * 16 * 16) + (j * 16 * 16) + (k * 16)), Number_Hex_Calculator.Program.HexConverter(i * 100 + j * 10 + k));
                    }
                }
            }
        }

        [TestMethod]
        public void DoubleConverterTest()
        {
            Assert.AreEqual(3.5, (Number_Hex_Calculator.Program.StringToDouble("7")) / 2);
        }

        [TestMethod]
        public void CalculatorTest()
        {
            Assert.AreEqual(3.5, (Number_Hex_Calculator.Program.Calculator("7/2")));
        }
    }
}
