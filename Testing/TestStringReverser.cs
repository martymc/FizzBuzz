using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringReverse;

namespace Testing
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class TestStringReverser
    {
        public TestStringReverser()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ReverseString()
        {
            string testString = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            testString = Reverser.ReverseString(testString);

            Assert.AreEqual(testString, ".murobal tse di mina tillom tnuresed aiciffo iuq apluc ni tnus ,tnediorp non tatadipuc taceacco tnis ruetpecxE .rutairap allun taiguf ue erolod mullic esse tilev etatpulov ni tiredneherper ni rolod eruri etua siuD .tauqesnoc odommoc ae xe piuqila tu isin sirobal ocmallu noitaticrexe durtson siuq ,mainev minim da mine tU .auqila angam erolod te erobal tu tnudidicni ropmet domsuie od des ,tile gnicisipida rutetcesnoc ,tema tis rolod muspi meroL");
        }

        [TestMethod]
        public void ReverseNullString()
        {
            string nullString = null;
            nullString = Reverser.ReverseString(nullString);

            Assert.AreEqual(nullString, null);
        }

        [TestMethod]
        public void ReverseEmptyString()
        {
            string emptyString = "";
            emptyString = Reverser.ReverseString(emptyString);
            Assert.AreEqual(emptyString, "");
        }

        [TestMethod]
        public void ReverseSingleCharacterString()
        {
            string singleCharString = "a";
            singleCharString = Reverser.ReverseString(singleCharString);
            Assert.AreEqual(singleCharString, "a");
        }

        //recursive method
        [TestMethod]
        public void ReverseStringRecursion()
        {
            string testString = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            string result = Reverser.ReverseStringRecurse(testString, testString.Length);

            Assert.AreEqual(result, ".murobal tse di mina tillom tnuresed aiciffo iuq apluc ni tnus ,tnediorp non tatadipuc taceacco tnis ruetpecxE .rutairap allun taiguf ue erolod mullic esse tilev etatpulov ni tiredneherper ni rolod eruri etua siuD .tauqesnoc odommoc ae xe piuqila tu isin sirobal ocmallu noitaticrexe durtson siuq ,mainev minim da mine tU .auqila angam erolod te erobal tu tnudidicni ropmet domsuie od des ,tile gnicisipida rutetcesnoc ,tema tis rolod muspi meroL");
        }

        [TestMethod]
        public void NullStringRecursion()
        {
            string testString = null;
            testString = Reverser.ReverseStringRecurse(testString, 0);

            Assert.AreEqual(testString, null);
        }

        [TestMethod]
        public void SingleCharRecursion()
        {
            string testString = "a";
            testString = Reverser.ReverseStringRecurse(testString, 1);

            Assert.AreEqual(testString, "a");
        }

        [TestMethod]
        public void EmptyStringRecursion()
        {
            string testString = "";
            testString = Reverser.ReverseStringRecurse(testString, 0);

            Assert.AreEqual(testString, "");
        }
    }
}
