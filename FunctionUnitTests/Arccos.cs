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
        [ExpectedException(typeof(System.ArgumentException))]
        // Arccos undefined outside of [-1, 1] so we expect an exception
        public void Exception_Undefined_Range_Negative()
        {
            ScientificCalculator.Math.Arccos(1.5);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        // Arccos undefined outside of [-1, 1] so we expect an exception
        public void Exception_Undefined_Range_Positive()
        {
            ScientificCalculator.Math.Arccos(-2);
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
            const double test_value = 0.7;

            double custom_result = ScientificCalculator.Math.Arccos(test_value);
            double native_result = System.Math.Acos(test_value);

            testContextInstance.WriteLine($"Custom: {custom_result}, Native: {native_result}");

            Assert.AreEqual(native_result, custom_result, 0.001);
        }

        [TestMethod]
        public void Correct_Value_Static_Test_Two()
        {
            const double test_value = 0.23;

            double custom_result = ScientificCalculator.Math.Arccos(test_value);
            double native_result = System.Math.Acos(test_value);

            testContextInstance.WriteLine($"Custom: {custom_result}, Native: {native_result}");

            Assert.AreEqual(native_result, custom_result, 0.001);
        }

        [TestMethod]
        // Test random number value between -1 and 1
        public void Correct_Value_Test_Random()
        {
            System.Random rand = new System.Random();

            // Generate a random number between -1 and 1 rounded to three decimal places
            double test_value = System.Math.Round(rand.NextDouble() * 2 - 1, 3);

            double custom_result = ScientificCalculator.Math.Arccos(test_value);
            double native_result = System.Math.Acos(test_value);

            testContextInstance.WriteLine($"Test Value: {test_value}, Custom: {custom_result}, Native: {native_result}");

            Assert.AreEqual(native_result, custom_result, 0.001);
        }
    }
}
