using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionUnitTests
{
    [TestClass]
    public class Power
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        // a * b^x

        [TestMethod]
        // 0 * 1/0 = Error
        public void Power_ExceptionalCaseZeroOneZero_ArgumentExceptionThrown()
        {
            Assert.IsTrue(double.IsNaN(0 * ScientificCalculator.Math.Power(0, -1)));
        }

        [TestMethod]
        // 0 * x^y = 0
        public void Power_InputIsZero_ReturnZero()
        {
            System.Random rand = new System.Random();
            double result = 0 * ScientificCalculator.Math.Power(rand.NextDouble(), rand.NextDouble());
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        // a * 0^0 = 1
        public void Power_BaseIsZeroZeroExponent_ReturnOne()
        {
            System.Random rand = new System.Random();
            double result = ScientificCalculator.Math.Power(0, 0);
            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        // a * 0^y = 0
        public void Power_BaseIsZeroPositiveExponent_ReturnZero()
        {
            System.Random rand = new System.Random();
            double result = rand.NextDouble() * ScientificCalculator.Math.Power(0, rand.NextDouble());
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        // a * 0^-y = inf
        public void Power_BaseIsZeroNegativeExponent_ReturnPositiveInfinity()
        {
            System.Random rand = new System.Random();
            double result = rand.NextDouble() * ScientificCalculator.Math.Power(0, -1 * rand.NextDouble());
            Assert.IsTrue(result == double.PositiveInfinity);
        }

        [TestMethod]
        // Test random integer exponent value
        public void Power_CorrectValue_IntegerExponent_TestRandom()
        {
            double max = 10000;
            double min = -10000;
            System.Random random = new System.Random();

            var tempVar = random.NextDouble();
            double a = (tempVar * max + (1 - tempVar) * min);

            tempVar = random.NextDouble();
            double b = tempVar * max + (1 - tempVar) * min;

            int x = random.Next(int.MinValue, int.MaxValue);

            double custom_result = a * ScientificCalculator.Math.Power(b, x);
            double native_result = a * System.Math.Pow(b, x);

            testContextInstance.WriteLine($"Custom: {custom_result}, Native: {native_result}");
            Assert.AreEqual(custom_result, native_result);
        }

        [TestMethod]
        // Test random double exponent value
        public void Power_CorrectValue_Algebraic()
        {
            double a = 1;
            double b = System.Math.Sqrt(2);
            double x = 12;

            double custom_result = a * ScientificCalculator.Math.Power(b, x);
            double native_result = a * System.Math.Pow(b, x);

            testContextInstance.WriteLine($"Custom: {custom_result}, Native: {native_result}");
            Assert.AreEqual(custom_result, native_result, 0.000001);
        }
    }
}
