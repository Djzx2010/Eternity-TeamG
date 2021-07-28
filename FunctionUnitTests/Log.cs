using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionUnitTests
{
    [TestClass]
    public class Log
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        // Log undefined for base values <= 0
        public void Undefined_Range_Base()
        {
            var testValueBase = -1;
            var testValue = 12;

            Assert.IsTrue(double.IsNaN(ScientificCalculator.Math.Log(testValueBase, testValue)));
        }

        [TestMethod]
        // Log undefined for values <= 0
        public void Undefined_Range_Value()
        {
            var testValueBase = 2;
            var testValue = -12;

            Assert.IsTrue(double.IsNaN(ScientificCalculator.Math.Log(testValueBase, testValue)));
        }

        [TestMethod]
        public void Correct_Value_Test_Random_Decimal()
        {
            System.Random rand = new System.Random();

            var maxBase = 1000;
            var minBase = 1;

            double maxValue = 1000;
            double minValue = 1;

            var tempVar = rand.NextDouble();
            var testValueBase = rand.Next(minBase, maxBase);

            double testValue = System.Math.Round((tempVar * maxValue + (1 - tempVar) * minValue), 3);

            double custom_result = ScientificCalculator.Math.Log(testValueBase, testValue);
            double native_result = System.Math.Log(testValue, testValueBase);

            testContextInstance.WriteLine($"Test Value: {testValue} using Base: {testValueBase}, Custom: {custom_result}, Native: {native_result}");

            Assert.AreEqual(native_result, custom_result, 0.001);
        }

        [TestMethod]
        public void Correct_Value_Test_Random()
        {
            System.Random rand = new System.Random();

            var maxBase = 1000;
            var minBase = 1;

            var maxValue = 10000;
            var minValue = 1;

            var testValueBase = rand.Next(minBase, maxBase);
            var testValue = rand.Next(minValue, maxValue);

            double custom_result = ScientificCalculator.Math.Log(testValueBase, testValue);
            double native_result = System.Math.Log(testValue, testValueBase);

            testContextInstance.WriteLine($"Test Value: {testValue} using Base: {testValueBase}, Custom: {custom_result}, Native: {native_result}");

            Assert.AreEqual(native_result, custom_result, 0.001);
        }

        [TestMethod]
        public void Correct_Value_Test_Static_One()
        {
            var testValueBase = 2;
            var testValue = 800.85;

            double custom_result = ScientificCalculator.Math.Log(testValueBase, testValue);
            double native_result = System.Math.Log(testValue, testValueBase);

            testContextInstance.WriteLine($"Test Value: {testValue} using Base: {testValueBase}, Custom: {custom_result}, Native: {native_result}");

            Assert.AreEqual(native_result, custom_result, 0.001);
        }

        [TestMethod]
        public void Correct_Value_Test_Static_Two()
        {
            var testValueBase = 10;
            var testValue = 777.777;

            double custom_result = ScientificCalculator.Math.Log(testValueBase, testValue);
            double native_result = System.Math.Log(testValue, testValueBase);

            testContextInstance.WriteLine($"Test Value: {testValue} using Base: {testValueBase}, Custom: {custom_result}, Native: {native_result}");

            Assert.AreEqual(native_result, custom_result, 0.001);
        }

        [TestMethod]
        public void Correct_Value_Test_Algebraic()
        {
            var testValueBase = 10;
            var testValue = System.Math.Sqrt(2);

            double custom_result = ScientificCalculator.Math.Log(testValueBase, testValue);
            double native_result = System.Math.Log(testValue, testValueBase);

            testContextInstance.WriteLine($"Test Value: {testValue} using Base: {testValueBase}, Custom: {custom_result}, Native: {native_result}");

            Assert.AreEqual(native_result, custom_result, 0.001);
        }
    }
}
