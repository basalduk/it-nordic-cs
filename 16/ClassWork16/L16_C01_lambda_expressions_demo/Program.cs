using System;

namespace L15_C11_lambda_expressions_demo
{
	class Program
	{
		delegate int DoCalculation(int number1, int number2);

		static int Sum(int x, int y)
		{
			return x + y;
		}

		static void Main(string[] args)
		{
			DoCalculation action1 = Sum; // assuming this method defined
			Console.WriteLine($"{action1(1, 2)}");

			DoCalculation action2 = (int x, int y) => x * y;
			Console.WriteLine($"{action2(3, 5)}");

			DoCalculation action3 =
				(x, y) =>
				{
					int z = x * y;
					return z;
				};
			Console.WriteLine($"{action2(3, 5)}");

			// you can omit parentheses in case of the single parameter
			Action<string> action4 = x => Console.WriteLine(x);
			action4("test");

			// you should use empty parentheses in case of absense ot the parameters
			Func<float> getPi = () => MathF.PI;
			Console.WriteLine(getPi());
		}
	}
}
