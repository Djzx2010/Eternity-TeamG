

namespace ScientificCalculator
{
	class Math
	{
		private const double TOLERANCE = 0.0000000001;

		public static double Abs(double x)
		{
			return x >= 0.0 ? x : -x;
		}

		public static double Round(double x, uint place)
        {
			uint i;
			for (i = 0; i<place;i++)
				x *= 10;
			x = (double)((decimal)(x + 0.5));
			for (i = 0; i < place; i++)
				x *= 0.1;
			return x;
		}

		public static double Sqrt(double x)
		{
			double sqrt;
			double x0 = x;

			while (true)
			{
				sqrt = 0.5 * (x + (x0 / x));
				if (Abs(sqrt - x) < TOLERANCE)
					break;
				x = sqrt;
			}
			return sqrt;
		}

		public static double Square(double x)
		{
			return x * x;
		}

		public static double Mean(params double[] x)
		{
			double mean = 0.0;
			for (uint i = 0; i < x.Length; i++)
				mean += x[i];
			return mean / x.Length;
		}

		public static double StdDev(params double[] x)
		{
			int n = x.Length;
			if (n > 0)
			{
				double sigma = 0.0;
				double _mean = Mean(x);
				for (uint i = 0; i < n; i++)
					sigma += Square(x[i] - _mean);
				return Sqrt(sigma / n);
			}
			else
				return 0.0;
		}
	}
}
