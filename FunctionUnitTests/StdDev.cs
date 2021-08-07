using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace FunctionUnitTests
{
    public static class Helper
    {
        public static double standardDeviation(this IEnumerable<double> sequence)
        {
            double average = sequence.Average();
            double sum = sequence.Sum(d => Math.Pow(d - average, 2));
            return Math.Sqrt((sum) / (sequence.Count()));
        }
    }

    [TestClass]
    public class StdDev
    {

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void Correct_Test_Invalid_input()
        {
            double[] arr = new double[1];
            arr[0] = 0;

            double custom_result = ScientificCalculator.Math.StdDev(arr);
            Assert.AreEqual(custom_result, double.NaN);
        }


        [TestMethod]
        public void Correct_Test_Algebraic()
        {
            double[] arr = new double[10];
            System.Random random = new System.Random();
            for (int i = 0; i < 10; i++)
                arr[i] = random.NextDouble();

            double custom_result = ScientificCalculator.Math.StdDev(arr);
            double native_result = Helper.standardDeviation(arr);

            testContextInstance.WriteLine($"Test Value: {arr}, Custom: {custom_result}, Native: {native_result}");

            Assert.AreEqual(native_result, custom_result, 0.00001);
        }

    }
}
