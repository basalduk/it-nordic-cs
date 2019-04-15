using System;

namespace ClassLibrary1
{
	public class CircleOperation
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
