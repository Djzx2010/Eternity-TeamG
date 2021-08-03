
namespace ScientificCalculator
{
	public enum TrigUnits
    {
		RAD,
		DEG
    }

	public class Math
	{
		public const double PI = 3.141592653589793;
		private const double TOLERANCE = 0.0000000001;
		private const double EULERS_NUMBER = 2.7182818284590452353602874713527;
		private const int ACCURACY = 1000000;
		// Default to RAD
		private static TrigUnits unitType = TrigUnits.RAD;

		public static TrigUnits GetUnitType()
        {
			return unitType;
        }

		public static void toggleTrigUnits()
        {
			if (unitType == TrigUnits.RAD)
            {
				unitType = TrigUnits.DEG;
            }
			else if (unitType == TrigUnits.DEG)
            {
				unitType = TrigUnits.RAD;
			}
        }

		public static double Abs(double x)
		{
			return (x >= 0.0) ? x : -x;
		}

		public static double Round(double x, uint place)
		{
			var i = 0;
			for (; i < place; i++)
			{
				x *= 10;
			}

			x = (double)((decimal)(x + 0.5));

			for (i = 0; i < place; i++)
			{
				x *= 0.1;
			}

			return x;
		}

		public static double Sqrt(double x)
		{
			if (x < 0)
				return double.NaN;

			double sqrt;
			double x0 = x;

			while (true)
			{
				sqrt = 0.5 * (x + (x0 / x));

				if (Abs(sqrt - x) < TOLERANCE)
				{
					break;
				}

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
			if (x.Length == 0)
				return double.NaN;

			double mean = 0.0;

			for (var i = 0; i < x.Length; i++)
			{
				mean += x[i];
			}

			return mean / x.Length;
		}

		public static double StdDev(params double[] x)
		{
			var n = x.Length;

			if (n > 1)
			{
				double sigma = 0.0;
				double _mean = Mean(x);

				for (var i = 0; i < n; i++)
				{
					sigma += Square(x[i] - _mean);
				}

				return Sqrt(sigma / n);
			}
			else
			{
				return double.NaN;
			}

		}

		public static double Sinh(double x)
		{
			double result = (Power(EULERS_NUMBER, x) - Power(EULERS_NUMBER, (x * -1))) / 2;

			if (unitType == TrigUnits.DEG)
			{
				result = toDegrees(result);
			}

			return result;
		}


		public static double MeanAbsoluteDeviation(params double[] x)
		{
			var mean = Mean(x);
			var n = x.Length;
			var sum = 0.0;

			for (var i = 0; i < x.Length; i++)
			{
				sum += Abs(x[i] - mean);
			}

			return sum / n;
		}

		public static double Sin(double x) // using Taylor's Series
		{
			const int TERMS = 7;
			double rad = x;
			if (unitType == TrigUnits.DEG)
			{
				rad %= 360;
				rad *= PI / 180;
			}
			else
				rad %= PI;
			double sin = 0;

			for (int i = 0; i < TERMS; i++)
			{
				sin += (Power(-1, i) * Power(rad, 2 * i + 1) / Factorial(2 * i + 1));
			}
			return sin;
		}


		// Lanczos Approximation 
		private const int g = 7;
		private const int n = 8;
		private const double _SQRT_2PI = 0.91893853320467274178;
		private static readonly double[] p = {
			0.99999999999980993, 676.5203681218851, -1259.1392167224028,
			771.32342877765313, -176.61502916214059, 12.507343278686905,
			-0.13857109526572012, 9.9843695780195716e-6, 1.5056327351493116e-7
		};

		public static double Gamma(double x)
		{
			return Power(EULERS_NUMBER, LnGamma(x));
		}
		public static double LnGamma(double x)
		{

			if (x < 0.5)
			{
				// Use Euler's reflection formula:
				// Gamma(x) = Pi / [Sin[Pi*z] * Gamma[1-z]];
				// TODO: Replace sinh with sin
				return Log(EULERS_NUMBER, PI / Sin(PI * x)) - LnGamma(1.0 - x);
			}

			else
			{
				x -= 1.0;
				var sum = 0.0;
				var ba = x + g + 0.5;

				for (var i = n; i >= 1; i--)
				{
					sum += p[i] / (x + i);
				}

				sum += p[0];

				// TODO: Update these to not use built in functions
				return ((_SQRT_2PI + Log(EULERS_NUMBER, sum)) - ba) + Log(EULERS_NUMBER, ba) * (x + 0.5);
			}

		}

		/* Arccos calculating using Taylor-Series, currently defaults to rads */
		public static double Arccos(double x)
		{
			// Arccos is only defined within the range of [-1, 1]
			if (x < -1 || x > 1)
			{
				return double.NaN;
			}


			double result = 0;

			// Arccos(1) = 0 and Arccos(-1) = PI, return the values right away instead of wasting resources calculating
			if (x == 1)
			{
				return result;
			}
			else if (x == -1)
			{
				return PI;
			}
			else
			{
				for (var i = 0; i < 99; i++)
				{
					var fact = Factorial(2 * i);
					var pow1 = Power(2, 2 * i);
					var pow2 = Power(Factorial(i), 2);
					var exponent = (2 * i) + 1;
					var b = Power(x, exponent) / exponent;

					if (double.IsInfinity(fact))
					{
						break;
					}

					result += ((fact / (pow1 * pow2)) * b);
				}

				result = ((PI / 2) - result);

				if(unitType == TrigUnits.DEG)
                {
					result = toDegrees(result);
                }

				return result;
			}
		}

		// Convert RADS to DEG
		public static double toDegrees(double rads)
        {
			return rads * (180 / PI);
		}

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

		//Logarithmic Function
		public static double Log(double _base, double exponentLog)
		{
			// https://www.codeproject.com/Tips/311714/Natural-Logarithms-and-Exponent

			double result = 0;
			var sign = 1; //negative or postive

			//No negative logs or 0 logs allowed, results undefined
			if (exponentLog <= 0 || _base <= 0)
			{
				return double.NaN;
			}
			//Infinite results
			if (_base == 1)
			{
				if (exponentLog == 1)
				{
					return double.NaN;
				}
				return double.PositiveInfinity;
			}

			//Dealing with decimal bases/exponents
			if (exponentLog < 1)
			{
				exponentLog = 1 / exponentLog;
				sign *= -1;
			}
			if (_base < 1)
			{
				_base = 1 / _base;
				sign *= -1;
			}


			double count = exponentLog;

			while (count >= _base)
			{
				result++;
				count /= _base;
			}

			if (count == 1)
			{
				return (sign * result);
			}

			return sign * (result + (1 / Log(count, _base)));
		}

		// Aux function: Power function (double^int).
		public static double Power(double x, int y)
		{
			double res = 1;

			if (y > 0)
			{
				for (int i = 1; i <= y; ++i)
				{
					res *= x;
				}
			}
			else if (y < 0)
			{
				for (int i = -1; i >= y; --i)
				{
					res /= x;
				}
			}

			return res;
		}

		// Aux function: Power function (double^double).
		public static double Power(double b, double x)
		{
			if (b == 0)
			{
				if (x == 0)
				{
					return 1;
				}
				else if (x > 0)
				{
					return b;
				}
				else
				{
					return double.PositiveInfinity;
				}
			}

			if (x % 1 == 0)
			{
				return Power(b, (int)x);
			}
			else
			{
				if (b < 0)
				{
					return double.NaN;
				}
				else
				{
					bool negative = x < 0;
					x = Abs(x);
					bool smallBase = (b > 1 && x > 1) || (b < 1 && x < 1);

					double total = Log(EULERS_NUMBER, b) * ACCURACY * x;
					double tempAccuracy = 1.0 + 1.0 / ACCURACY;
					double res = b;

					while (true)
					{
						double t2 = Log(EULERS_NUMBER, res) * ACCURACY;

						if ((smallBase && t2 > total) || (!smallBase && t2 < total))
						{
							break;
						}

						if (smallBase)
						{
							res *= tempAccuracy;
						}
						else
						{
							res /= tempAccuracy;
						}
					}

					if (negative)
					{
						res = 1 / res;
					}

					return res;
				}
			}
		}

		// ab^x
		// Power function (double * double^double).
		public static double Power(double a, double b, double x)
		{
			if (a == 0)
			{
				if (b == 0 && x == -1)
				{
					return double.NaN;
				}
				else
				{
					return a;
				}
			}
			else
			{
				if (x == 0 && b == 0)
				{
					return 1;
				}
				else
				{
					return a * Power(b, x);
				}
			}
		}
	}
}