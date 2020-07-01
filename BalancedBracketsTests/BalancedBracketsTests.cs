using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);         
            
        }

        //test cases
        string[] caseTrue = { "", "[]", "[[]]", "[[[]]]", "[][]" };
        string[] caseFalse = { "]", "[", "][", "[[", "]]", "[[]", "[]]" };
        

        [TestMethod]
        public void Test2()  //Empty String
        {
            string testString = caseTrue[0];
            bool boolExpected = true;
            bool boolActual = BalancedBrackets.HasBalancedBrackets(testString);
            
            Assert.AreEqual(boolExpected, boolActual); 
        }


        [TestMethod]
        public void Test3()  //"[]"
        {
            string testString = caseTrue[1];
            bool boolExpected = true;
            bool boolActual = BalancedBrackets.HasBalancedBrackets(testString);

            Assert.AreEqual(boolExpected, boolActual);
        }


        [TestMethod]
        public void Test4()  //"[[]]"
        {
            string testString = caseTrue[2];
            bool boolExpected = true;
            bool boolActual = BalancedBrackets.HasBalancedBrackets(testString);

            Assert.AreEqual(boolExpected, boolActual);
        }


        [TestMethod]
        public void Test5()  //"[[[]]]"
        {
            string testString = caseTrue[3];
            bool boolExpected = true;
            bool boolActual = BalancedBrackets.HasBalancedBrackets(testString);

            Assert.AreEqual(boolExpected, boolActual);
        }


        [TestMethod]
        public void Test6()  //"[][]"
        {
            string testString = caseFalse[0];
            bool boolExpected = false;
            bool boolActual = BalancedBrackets.HasBalancedBrackets(testString);
            
            Assert.AreEqual(boolExpected, boolActual); 
        }


        [TestMethod]
        public void Test7()  //"]"
        {
            string testString = caseFalse[1];
            bool boolExpected = false;
            bool boolActual = BalancedBrackets.HasBalancedBrackets(testString);

            Assert.AreEqual(boolExpected, boolActual);
        }


        [TestMethod]
        public void Test8()  //"["
        {
            string testString = caseFalse[2];
            bool boolExpected = false;
            bool boolActual = BalancedBrackets.HasBalancedBrackets(testString);

            Assert.AreEqual(boolExpected, boolActual);
        }


        [TestMethod]
        public void Test9()  //"[["
        {
            string testString = caseFalse[3];
            bool boolExpected = false;
            bool boolActual = BalancedBrackets.HasBalancedBrackets(testString);

            Assert.AreEqual(boolExpected, boolActual);
        }


        [TestMethod]
        public void Test10()  //"]]"
        {
            string testString = caseFalse[4];
            bool boolExpected = false;
            bool boolActual = BalancedBrackets.HasBalancedBrackets(testString);

            Assert.AreEqual(boolExpected, boolActual);
        }


        [TestMethod]
        public void Test11()  //"[[]"
        {
            string testString = caseFalse[5];
            bool boolExpected = false;
            bool boolActual = BalancedBrackets.HasBalancedBrackets(testString);

            Assert.AreEqual(boolExpected, boolActual);
        }


        [TestMethod]
        public void Test12()  //"[]]"
        {
            string testString = caseFalse[6];
            bool boolExpected = false;
            bool boolActual = BalancedBrackets.HasBalancedBrackets(testString);

            Assert.AreEqual(boolExpected, boolActual);
        }
    }
}
