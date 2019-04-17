using System;
using Calculator.Figure;
using Calculator.Operation;

namespace MathOperation
{
	class Program
	{
		static void Main(string[] args)
		{
			const double circleRadius = 1.5;
			var circle = new Circle(circleRadius);

			var circlePerimeter =
				circle.Calculate(CircleOperation.CalculatePerimeter);

			var circleSquare =
				circle.Calculate(CircleOperation.CalculateSquare);

			Console.WriteLine(
				$"For the circle with radius {circleRadius}\n" +
				$"\tPerimeter is\t{circlePerimeter}\n" +
				$"\tSquare is\t{circleSquare}");

			const double squareSide = 7.5;
			var square = new Square(squareSide);

			var squarePerimeter =
				square.Calculate(SquareOperation.CalculatePerimeter);

			var squareSquare =
				square.Calculate(SquareOperation.CalculateSquare);

			Console.WriteLine(
				$"For the square with side {squareSide}\n" +
				$"\tPerimeter is\t{squarePerimeter}\n" +
				$"\tSquare is\t{squareSquare}");
		}
	}
}
