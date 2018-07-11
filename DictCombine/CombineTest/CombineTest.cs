//-----------------------------------------------------------------------
// <copyright file="CombineTest.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace CombineTest
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The unit test class 
    /// </summary>
    [TestClass]
    public class CombineTest
    {
        private static readonly Dictionary<string, string> dict1 = new Dictionary<string, string>()
        {
            { "cat", "big"},
            { "smallcat", "small"},
            { "bigcat", "large"},
            { "shortcat", "short"},
        };

        private static readonly Dictionary<string, string> dict2 = new Dictionary<string, string>()
        {
            { "dog", "big"},
            { "smalldog", "small"},
            { "bigdog", "large"},
            { "shortdog", "short"},
        };

        /// <summary>
        /// Test method that tests if the dictionary combine method result would have all the right keys from the two that were combined
        /// </summary>
        [TestMethod]
        public void TestCombineDictSameKeys()
        {
            var combinedDict = DictArrayCombine.Program.CombineDict(dict1, dict2);

            Assert.AreEqual(combinedDict.Count, dict1.Count + dict2.Count);
            DictionaryContainsAnother(combinedDict, dict1);
            DictionaryContainsAnother(combinedDict, dict2);
        }

        /// <summary>
        /// Test have common key
        /// </summary>
        [TestMethod]
        public void TestCombineDictHasCommonKey()
        {
            var commonKey = "commonKey";
            var commonValue1 = "commonValue1";
            var commonValue2 = "commonValue2";
            var dict1WithCommon = new Dictionary<string, string>(dict1);
            dict1WithCommon.Add(commonKey, commonValue1);
            var dict2WithCommon = new Dictionary<string, string>(dict2);
            dict2WithCommon.Add(commonKey, commonValue2);

            var combinedDict = DictArrayCombine.Program.CombineDict(dict1WithCommon, dict2WithCommon);

            Assert.AreEqual(combinedDict.Count, dict1.Count + dict2.Count + 1);
            DictionaryContainsAnother(combinedDict, dict1);
            DictionaryContainsAnother(combinedDict, dict2);
            string value;
            Assert.IsTrue(combinedDict.TryGetValue(commonKey,out value));
            Assert.AreEqual(commonValue1, value);
        }

        /// <summary>
        /// Test have common key
        /// </summary>
        [TestMethod]
        public void TestCombineDictFirstIsEmpty()
        {
            var combinedDict = DictArrayCombine.Program.CombineDict(new Dictionary<string, string>(), dict2);

            Assert.AreEqual(combinedDict.Count, dict2.Count);
            DictionaryContainsAnother(combinedDict, dict2);
        }

        /// <summary>
        /// Test have common key
        /// </summary>
        [TestMethod]
        public void TestCombineDictSecondIsEmpty()
        {
            var combinedDict = DictArrayCombine.Program.CombineDict(dict1, new Dictionary<string, string>());

            Assert.AreEqual(combinedDict.Count, dict1.Count);
            DictionaryContainsAnother(combinedDict, dict1);
        }

        private static void DictionaryContainsAnother(Dictionary<string, string> combinedDict, Dictionary<string, string> subSet)
        {
            foreach (var item in subSet)
            {
                string value;
                Assert.IsTrue(combinedDict.TryGetValue(item.Key, out value));
                Assert.AreEqual(item.Value, value);
            }
        }
    }
}
