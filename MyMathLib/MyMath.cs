namespace MyMathLib
{
	/// <summary>
	/// Provides basic arithmetic operations with support for integers, doubles, and string representations of numbers.
	/// </summary>
	public class MyMath
	{
		/// <summary>
		/// Adds two integers and returns the result as a double.
		/// </summary>
		public static double Add(int x, int y)
		{
			return Add((double)x, (double)y);		
		}

		/// <summary>
		/// Adds two double-precision floating-point numbers.
		/// </summary>
		public static double Add(double x, double y) 
		{ 
			return x + y; 
		}

		/// <summary>
		/// Parses two strings to numeric values and returns their sum as a double.
		/// </summary>
		/// <exception cref="ArgumentException">Thrown if parsing fails.</exception>
		public static double Add(string x, string y) 
		{
			if (int.TryParse(x, out int resultIntX) && int.TryParse(y, out int resultIntY))
			{
				return Add(resultIntX, resultIntY);
			}
			if (double.TryParse(x, out double resultDoubleX) 
				&& double.TryParse(y, out double resultDoubleY))
			{
				return Add(resultDoubleX, resultDoubleY);
			}
			throw new ArgumentException("Недопустимые параметры функции");
		}

		/// <summary>
		/// Subtracts two integers and returns the result as a double.
		/// </summary>
		public static double Substract(int x, int y)
		{
			return Substract((double)x, (double)y);
		}

		/// <summary>
		/// Subtracts two double-precision floating-point numbers.
		/// </summary>
		public static double Substract(double x, double y)
		{
			return x - y;
		}

		/// <summary>
		/// Parses two strings to numeric values, subtracts the second from the first, and returns the result as a string.
		/// </summary>
		/// <exception cref="ArgumentException">Thrown if parsing fails.</exception>
		public static string Substract(string x, string y)
		{
			if (int.TryParse(x, out int resultIntX) && int.TryParse(y, out int resultIntY))
			{
				return Substract(resultIntX, resultIntY).ToString();
			}
			if (double.TryParse(x, out double resultDoubleX)
				&& double.TryParse(y, out double resultDoubleY))
			{
				return Substract(resultDoubleX, resultDoubleY).ToString();
			}
			throw new ArgumentException("Недопустимые параметры функции");
		}



		/// <summary>
		/// Multiplies two integers and returns the result as a double.
		/// </summary>
		public static double Multiply(int x, int y)
		{
			return Multiply((double)x, (double)y);
		}

		/// <summary>
		/// Multiplies two double-precision floating-point numbers.
		/// </summary>
		public static double Multiply(double x, double y)
		{
			return x * y;
		}

		/// <summary>
		/// Parses two strings to numeric values, multiplies them, and returns the result as a string.
		/// </summary>
		/// <exception cref="ArgumentException">Thrown if parsing fails.</exception>
		public static string Multiply(string x, string y)
		{
			if (int.TryParse(x, out int resultIntX) && int.TryParse(y, out int resultIntY))
			{
				return Multiply(resultIntX, resultIntY).ToString();
			}
			if (double.TryParse(x, out double resultDoubleX)
				&& double.TryParse(y, out double resultDoubleY))
			{
				return Multiply(resultDoubleX, resultDoubleY).ToString();
			}
			throw new ArgumentException("Недопустимые параметры функции");
		}

		/// <summary>
		/// Divides two integers and returns the result as a double.
		/// </summary>
		public static double Divide(int x, int y)
		{
			return Divide((double)x, (double)y);
		}

		/// <summary>
		/// Divides two double-precision floating-point numbers.
		/// </summary>
		public static double Divide(double x, double y)
		{
			return x / y;
		}

		/// <summary>
		/// Parses two strings to numeric values, divides the first by the second, and returns the result as a string.
		/// </summary>
		/// <exception cref="ArgumentException">Thrown if parsing fails.</exception>
		public static string Divide(string x, string y)
		{
			if (int.TryParse(x, out int resultIntX) && int.TryParse(y, out int resultIntY))
			{
				return Divide(resultIntX, resultIntY).ToString();
			}
			if (double.TryParse(x, out double resultDoubleX)
				&& double.TryParse(y, out double resultDoubleY))
			{
				return Divide(resultDoubleX, resultDoubleY).ToString();
			}
			throw new ArgumentException("Недопустимые параметры функции");
		}


		/// <summary>
		/// Computes the square root of a double using the Newton-Raphson method with 15 iterations.
		/// </summary>
		public static double SquareRoot(double x)
		{
			double x0 = x / 2;
			for (int i = 0; i < 15; i++)
			{
				x0 = 1 / 2 * (x0 + x / x0);
			}
			return x0;
		}

		/// <summary>
		/// Computes the square root of an integer and returns the result as a double.
		/// </summary>
		public static double SquareRoot(int x)
		{
			return SquareRoot((double) x);
		}

		/// <summary>
		/// Parses a string to a numeric value and returns its square root as a string.
		/// </summary>
		/// <exception cref="ArgumentException">Thrown if parsing fails.</exception>
		public static string SquareRoot(string x)
		{
			if (int.TryParse(x, out int resultIntX))
			{
				return SquareRoot(resultIntX).ToString();
			}
			if (double.TryParse(x, out double resultDoubleX))
			{
				return SquareRoot(resultDoubleX).ToString();
			}
			throw new ArgumentException("Недопустимые параметры функции");
		}

		/// <summary>
		/// Computes the product of the base number multiplied by (the integer part of the exponent plus one).
		/// Note: This is not actual exponentiation but repeated addition.
		/// </summary>
		public static double Power(double x, double y)
		{
			double res = 0;
			for (int i = 0; i <= (int)y; i++)
			{
				res += x;
			}
			return res;
		}

		/// <summary>
		/// Computes the product of the base integer multiplied by (the exponent integer plus one).
		/// </summary>
		public static double Power(int x, int y)
		{
			return Power((double) x, (double) y);
		}

		/// <summary>
		/// Parses two strings to numeric values, computes their product via repeated addition, and returns the result as a string.
		/// </summary>
		/// <exception cref="ArgumentException">Thrown if parsing fails.</exception>
		public static string Power(string x, string y)
		{
			if (int.TryParse(x, out int resultIntX) && int.TryParse(y, out int resultIntY))
			{
				return Power(resultIntX, resultIntY).ToString();
			}
			if (double.TryParse(x, out double resultDoubleX)
				&& double.TryParse(y, out double resultDoubleY))
			{
				return Power(resultDoubleX, resultDoubleY).ToString();
			}
			throw new ArgumentException("Недопустимые параметры функции");
		}

	}
}
