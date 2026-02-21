using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests
{
    [TestFixture]
    public class ConsonantsCounterTests
    {
        [Test]
        public void Test_CountTotalConsonants_GetEmptyList_ReturnsZero()
        {
            List<string> allChars = new();

            int actual = ConsonantsCounter.CountTotalConsonants(allChars);

            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Test_CountTotalConsonants_GetListWithEmptyStringValues_ReturnsZero()
        {
            List<string> emptyString = new() { "" };

            int actual = ConsonantsCounter.CountTotalConsonants(emptyString);

            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Test_CountTotalConsonants_MultipleStrings_ReturnsConsonantsCount()
        {
            List<string> multipleString = new() { "bcd", "fgh", "jklm", "npqr", "stvwxyz" };

            int actual = ConsonantsCounter.CountTotalConsonants(multipleString);

            Assert.AreEqual(21, actual);
        }

        [Test]
        public void Test_CountTotalConsonants_GetStringsWithNoConsonants_ReturnsZero()
        {
            List<string> noConsonants = new() { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

            int actual = ConsonantsCounter.CountTotalConsonants(noConsonants);

            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Test_CountTotalConsonants_StringsWithMixedCaseConsonants_ReturnsConsonantsCount()
        {
            List<string> multipleString = new() { "Hello", "World", "ChatGPT" };

            int actual = ConsonantsCounter.CountTotalConsonants(multipleString);

            Assert.AreEqual(13, actual);
        }
    }

}

