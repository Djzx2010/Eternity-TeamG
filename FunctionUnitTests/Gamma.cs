using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionUnitTests
{
    [TestClass]
    public class Gamma
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void Correct_Test_Algebraic()
        {
            //double testValue = System.Math.Sqrt(2);
            double testValue = 2;

            double custom_result = ScientificCalculator.Math.Gamma(testValue);
            double native_result = MathNet.Numerics.SpecialFunctions.Gamma(testValue);

            testContextInstance.WriteLine($"Test Value: {testValue}, Custom: {custom_result}, Native: {native_result}");

            Assert.AreEqual(native_result, custom_result, 0.001);
        }
    }
}
