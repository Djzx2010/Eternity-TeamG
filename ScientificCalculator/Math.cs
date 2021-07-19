

namespace ScientificCalculator
{
	class Math
	{
		private const double TOLERANCE = 0.0000000001;
		private const double EULERS_NUMBER = 2.7182818284590452353602874713527;

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

		public static double Exponent(double x, double exponent)
		{
			if (exponent % 1 == 0) //Integer exponent
			{
				if (exponent == 0)
					return 1;

				double result = 1;
				bool isExponentPositive = exponent > 0;

				for (int i = 0; i < Math.Abs(exponent); i++)
					result = isExponentPositive ? result * x : result / x;

				return result;
			}
			else //Floating point exponent
            {
				//https://stackoverflow.com/a/29877278/7916867
				int accuracy = 1000000;
				double accuracy2 = 1.0 + 1.0 / accuracy;

				bool isExponentNegative = exponent < 0;
				exponent = Abs(exponent);

				bool isAnsMoreThanA = (x > 1 && exponent > 1) || (x < 1 && exponent < 1); //Example: 0.5^2=0.25 so answer is lower than A.
				double total = System.Math.Log(x) * accuracy * exponent; //TODO: Replace "System.Math.Log"

				double t = x;
				while (true)
				{
					double t2 = System.Math.Log(t) * accuracy; //TODO: Replace "System.Math.Log"
					if ((isAnsMoreThanA && t2 > total) || (!isAnsMoreThanA && t2 < total)) break;
					if (isAnsMoreThanA) t *= accuracy2;
					else t /= accuracy2;
				}

				if (isExponentNegative)
					t = 1 / t;

				return t;
			}
		}

		public static double Sinh(double x)
		{
			return (Exponent(EULERS_NUMBER, x) - Exponent(EULERS_NUMBER, (x * -1))) / 2;
		}


        public static double MeanAbsoluteDeviation(params double[] x)
        {
            double mean = Mean(x);
            double n = x.Length;
            double sum = 0.0;
            for (uint i = 0; i < x.Length; i++)
                sum += Abs(x[i] - mean);
            return sum / n;
        }


		// Lanczos Approximation 
		static int g = 7; static int n = 8;
		const double PI = 3.14159265358979323846;
		const double sqrt_2PI = 0.91893853320467274178;
		static double[] p = {0.99999999999980993, 676.5203681218851, -1259.1392167224028,
		 771.32342877765313, -176.61502916214059, 12.507343278686905,
		 -0.13857109526572012, 9.9843695780195716e-6, 1.5056327351493116e-7};

		public static double Gamma(double x)
        {
			double sum;
			double ba;
		
			if (x < 0.5) 
			{
				// Use Euler's reflection formula:
				//Gamma(x) = Pi / [Sin[Pi*z] * Gamma[1-z]];
				return log(PI / sin(PI * x)) - Gamma(1.0 - x);
			}

			else
            {
				x -= 1.0;
				ba = x + g + 0.5;
				sum = 0;
				
				for (int i = n; i >= 1; i--)
                {
					sum += p[i] / (x + ((double)i));
                }
				sum += p[0];

				return ((sqrt_2PI + log(sum)) - ba) + log(ba) * (x + 0.5);
			}

		}
	}
}
