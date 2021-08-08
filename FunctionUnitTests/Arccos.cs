using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionUnitTests
{
    [TestClass]
    public class Arccos
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        // Arccos undefined outside of [-1, 1] so we expect an exception
        public void Undefined_Range_Negative()
        {
            Assert.IsTrue(double.IsNaN(ScientificCalculator.Math.Arccos(1.5)));
        }

        [TestMethod]
        // Arccos undefined outside of [-1, 1] so we expect an exception
        public void Undefined_Range_Positive()
        {
            Assert.IsTrue(double.IsNaN(ScientificCalculator.Math.Arccos(1.5)));
        }

        [TestMethod]
        // We expect the value of Arccos(1) to be 0 as it's one of our predefined value results
        public void Correct_Value_Test_Range_One()
        {
            double result = ScientificCalculator.Math.Arccos(1);

            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        // We expect the value of Arccos(-1) to be PI as it's one of our predefined value results
        public void Correct_Value_Test_Range_Negative_One()
        {
            double result = ScientificCalculator.Math.Arccos(-1);

            Assert.IsTrue(result == System.Math.PI);
        }

        [TestMethod]
        public void Correct_Value_Static_Test()
        {
            const double testValue = 0.7;

            double customResult = ScientificCalculator.Math.Arccos(testValue);
            double nativeResult = System.Math.Acos(testValue);

            testContextInstance.WriteLine($"Custom: {customResult}, Native: {nativeResult}");

            Assert.AreEqual(nativeResult, customResult, 0.001);
        }

        [TestMethod]
        public void Correct_Value_Static_Test_Two()
        {
            const double testValue = 0.23;

            double customResult = ScientificCalculator.Math.Arccos(testValue);
            double nativeResult = System.Math.Acos(testValue);

            testContextInstance.WriteLine($"Custom: {customResult}, Native: {nativeResult}");

            Assert.AreEqual(nativeResult, customResult, 0.001);
        }

        [TestMethod]
        // Test random number value between -1 and 1
        public void Correct_Value_Test_Random()
        {
            System.Random rand = new System.Random();

            // Generate a random number between -1 and 1 rounded to three decimal places
            double testValue = System.Math.Round(rand.NextDouble() * 2 - 1, 3);

            double customResult = ScientificCalculator.Math.Arccos(testValue);
            double nativeResult = System.Math.Acos(testValue);

            testContextInstance.WriteLine($"Test Value: {testValue}, Custom: {customResult}, Native: {nativeResult}");

            Assert.AreEqual(nativeResult, customResult, 0.01);
        }

        [TestMethod]
        // Test random number value between -1 and 1
        public void Correct_Value_Test_Algebraic()
        {
            double testValue = System.Math.PI / 7;

            double customResult = ScientificCalculator.Math.Arccos(testValue);
            double nativeResult = System.Math.Acos(testValue);

            testContextInstance.WriteLine($"Custom: {customResult}, Native: {nativeResult}");

            Assert.AreEqual(nativeResult, customResult);
        }
    }
}
