using System;

namespace Operation
{
	public class Class1
	{
		public sealed class Circle
		{
			private double _radius;
			public Circle(double radius)
			{
				_radius = radius;
			}
			public double Calculator(Func<double, double> operation)
			{
				return operation(_radius);
			}
		}
	}
}
