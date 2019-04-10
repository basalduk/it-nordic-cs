using System;
using System.Collections.Generic;
using System.Text;

namespace CW
{
	public sealed class Circle
	{
		private double _radius;
		public Circle(double radius)
		{
			_radius = radius;
		}
		public double Calculator (Func< double, double> operation)
		{
			return operation(_radius);
		}

		public double Calculate(double radius)
		{
			return 2* Math.PI * radius;
		
		}

		double S = Math.PI * radius * radius;

	}
}
