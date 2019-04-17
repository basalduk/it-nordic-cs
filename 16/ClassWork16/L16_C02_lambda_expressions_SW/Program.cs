using System;

namespace L16_C02_lambda_expressions_SW
{
	class Program
	{
		static void Main(string[] args)
		{
			const double circleRadius = 1.5;
			var circle = new Circle(circleRadius);

			var circlePerimeter =
				circle.Calculate(x => 2 * Math.PI * x);

			var circleSquare =
				circle.Calculate(x => Math.PI * Math.Pow(x, 2));

			var circleDiameter =
				circle.Calculate(x => 2 * x);

			Console.WriteLine(
				$"For the circle with radius {circleRadius}\n" +
				$"\tPerimeter is\t{circlePerimeter}\n" +
				$"\tSquare is\t{circleSquare}\n" +
				$"\tDiameter is\t{circleDiameter}");
		}
	}
}
