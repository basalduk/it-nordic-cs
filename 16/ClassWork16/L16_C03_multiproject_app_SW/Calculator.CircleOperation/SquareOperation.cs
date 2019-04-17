using System;

namespace Calculator.Operation
{
	public static class SquareOperation
	{
		public static double CalculatePerimeter(double side)
		{
			return 4 * side;
		}

		public static double CalculateSquare(double side)
		{
			return Math.Pow(side, 2);
		}
	}
}
