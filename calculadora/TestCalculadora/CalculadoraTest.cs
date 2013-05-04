using calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCalculadora
{
    
    
    /// <summary>
    ///This is a test class for CalculadoraTest and is intended
    ///to contain all CalculadoraTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CalculadoraTest
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
        ///A test for somar
        ///</summary>
        [TestMethod()]
        public void somarTest()
        {
            Calculadora target = new Calculadora(); // TODO: Initialize to an appropriate value
            int a = 0; // TODO: Initialize to an appropriate value
            int b = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.somar(a, b);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Calculadora Constructor
        ///</summary>
        [TestMethod()]
        public void CalculadoraConstructorTest()
        {
            Calculadora target = new Calculadora();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
