using Microsoft.VisualStudio.TestTools.UnitTesting;
using static TDD.WordChecker;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string stringToCheck = "hejsa";
            char charToFind = 'h';

            //First Test
            Assert.IsTrue(ContainsChar(stringToCheck, charToFind));
            Assert.IsFalse(ContainsChar(stringToCheck, 'q'));

            //Second Test
            Assert.IsTrue(ContainsChar(stringToCheck, charToFind));
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Test 1
            Assert.AreEqual(3, ContainsCharCounter("hej med dig emil", 'e'));

            //Test 2
            Assert.AreEqual(3, ContainsCharCounter("hej med dig Emil", 'e'));
        }
    }
}
