using System;

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

		/* Arccos calculating using Taylor-Series, currently defaults to rads */
		public static double Arccos(double x)
        {
			// Exception for now, but probably needs to be something else
			// Arccos is only defined within the range of [-1, 1]
			if (x < -1 || x > 1) throw new System.ArgumentException();

			double result = 0;

			// Arccos(1) = 0 and Arccos(-1) = PI, return the values right away instead of wasting resources calculating
			if (x == 1)
            {
				return result;
            }
			else if (x == -1)
            {
				return System.Math.PI;
            }
			else
            {
				for (int i = 0; i < 99; i++)
                {
					double fact = Factorial(2 * i);
					double pow1 = Pow(2, 2 * i);
					double pow2 = Pow(Factorial(i), 2);

					int exponent = (2 * i) + 1;

					double b = Pow(x, exponent) / exponent;

					if (double.IsInfinity(fact)) break;

					result += ((fact / (pow1 * pow2)) * b);
                }

				result = ((System.Math.PI / 2) - result);

				// TODO: Maybe have a toggle between DEG and RADS?
				// return HelperFunctions.toDegrees(result);

				return result;
            }
        }

		// Convert RADS to DEG
		public static Func<double, double> toDegrees = (rads) => (rads * (180 / System.Math.PI));

		// Iterative factorial function
		public static double Factorial(int x)
		{
			double result = 1;

			if (x != 0)
			{
				for (int i = 1; i <= x; i++)
				{
					result *= i;
				}
			}

			return result;
		}

		// Iterative exponent function
		public static double Pow(double b, int pow)
		{
			double result = 1;

			if (pow != 0)
			{
				if (pow > 0)
				{
					for (int i = pow; i > 0; i--)
					{
						result *= b;
					}
				}
				else
				{
					for (int i = pow; i < 0; i++)
					{
						result *= b;
					}
				}
			}

			return result;
		}
	}
}
