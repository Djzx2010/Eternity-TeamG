namespace Calculator
{
	class MathFunctions
	{
		private static double TOLERANCE = 0.0000000001;

		public static double abs(double d)
		{
			return d >= 0.0 ? d : -d;

		}
		public static double sqrt(double x)
		{
			double x0 = x;
			double sqrt = 0.5 * (x + (x0 / x));

			while (true)
			{
				sqrt = 0.5 * (x + (x0 / x));
				if (abs(sqrt - x) < TOLERANCE)
					break;
				x = sqrt;
			}
			return sqrt;
		}

		public static double square(double x)
		{
			return x * x;
		}

		public static double mean(params double[] x)
		{
			double mean = 0.0;
			for (uint i = 0; i < x.Length; i++)
				mean += x[i];
			return mean / x.Length;
		}

		public static double sigma(params double[] x)
		{
			int n = x.Length;
			double sigma = 0.0;
			double _mean = mean(x);
			for (uint i = 0; i < n; i++)
				sigma += square(x[i] - _mean);
			return sqrt(sigma / n);
		}

	}
}