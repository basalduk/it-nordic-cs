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

		public double CalculatePerimetr(double radius)
		{
			return 2* Math.PI * radius;
		
		}
		public double CalculateSqware(double radius)
		{
			return Math.PI * radius * radius;

		}


	}
}
