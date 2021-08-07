using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionUnitTests
{
    [TestClass]
    public class Sinh
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        //[TestMethod]
        //public void Correct_Value_Test_Random_Decimal()
        //{
        //    System.Random rand = new System.Random();

        //    double max = 10000;
        //    double min = -10000;
        //    var tempVar = rand.NextDouble();

        //    double testValue = System.Math.Round((tempVar * max + (1 - tempVar) * min), 3);

        //    double custom_result = ScientificCalculator.Math.Sinh(testValue);
        //    double native_result = System.Math.Sinh(testValue);

        //    testContextInstance.WriteLine($"Test Value: {testValue}, Custom: {custom_result}, Native: {native_result}");

        //    Assert.AreEqual(native_result, custom_result, 0.01);
        //}

        [TestMethod]
        public void Correct_Value_Test_Random()
        {
            System.Random rand = new System.Random();

            int max = 10000;
            int min = -10000;

            double testValue = rand.Next(min, max);

            double custom_result = ScientificCalculator.Math.Sinh(testValue);
            double native_result = System.Math.Sinh(testValue);

            testContextInstance.WriteLine($"Test Value: {testValue}, Custom: {custom_result}, Native: {native_result}");

            Assert.AreEqual(native_result, custom_result, 0.1);
        }

        [TestMethod]
        public void Correct_Value_Test_Static_One()
        {
            double testValue = 1;

            double custom_result = ScientificCalculator.Math.Sinh(testValue);
            double native_result = System.Math.Sinh(testValue);

            testContextInstance.WriteLine($"Test Value: {testValue}, Custom: {custom_result}, Native: {native_result}");

            Assert.AreEqual(native_result, custom_result, 0.005);
        }

        [TestMethod]
        public void Correct_Value_Test_Static_Two()
        {
            double testValue = System.Math.PI;

            double custom_result = ScientificCalculator.Math.Sinh(testValue);
            double native_result = System.Math.Sinh(testValue);

            testContextInstance.WriteLine($"Test Value: {testValue}, Custom: {custom_result}, Native: {native_result}");

            Assert.AreEqual(native_result, custom_result, 0.005);
        }

        [TestMethod]
        public void Correct_Value_Algebaric()
        {
            double testValue = System.Math.Sqrt(2);

            double custom_result = ScientificCalculator.Math.Sinh(testValue);
            double native_result = System.Math.Sinh(testValue);

            testContextInstance.WriteLine($"Test Value: {testValue}, Custom: {custom_result}, Native: {native_result}");

            Assert.AreEqual(native_result, custom_result, 0.001);
        }
    }
}
