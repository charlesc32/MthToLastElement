using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FindMthCharTests
{
    
    
    /// <summary>
    ///This is a test class for ProgramTest and is intended
    ///to contain all ProgramTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgramTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for FindMthChar
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MthToLastElement.exe")]
        public void FindMthCharTest()
        {
            IEnumerable<string> array = new List<string>() { "a", "b", "c", "d" }; // TODO: Initialize to an appropriate value
            int index = 4; // TODO: Initialize to an appropriate value
            string expected = "a"; // TODO: Initialize to an appropriate value
            string actual;
            actual = Program_Accessor.FindMthChar(array, index);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DeploymentItem("MthToLastElement.exe")]
        public void FindMthCharTest2()
        {
            IEnumerable<string> array = new List<string>() { "e", "f", "g", "h" }; // TODO: Initialize to an appropriate value
            int index = 2; // TODO: Initialize to an appropriate value
            string expected = "g"; // TODO: Initialize to an appropriate value
            string actual;
            actual = Program_Accessor.FindMthChar(array, index);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DeploymentItem("MthToLastElement.exe")]
        public void FindMthCharTest3()
        {
            IEnumerable<string> array = new List<string>() { "e", "f", "g", "h" }; // TODO: Initialize to an appropriate value
            int index = 2; // TODO: Initialize to an appropriate value
            string expected = "g"; // TODO: Initialize to an appropriate value
            string actual;
            actual = Program_Accessor.FindMthChar(array, index);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for FindMthChar
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MthToLastElement.exe")]
        public void FindMthCharTest1()
        {
            IEnumerable<string> array = new List<string>() { "e", "f", "g", "h" }; // TODO: Initialize to an appropriate value
            int index = 5; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = Program_Accessor.FindMthChar(array, index);
            Assert.AreEqual(expected, actual);
        }
    }
}
