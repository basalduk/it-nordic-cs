using System;

namespace CW
{
	class Program
	{
		static void Main(string[] args)
		{
			
			var circlePerimetr = new Circle(15);
			Console.WriteLine(circlePerimetr.Calculator((double radius) => 2 * Math.PI * radius));

			var circleSqware = new Circle(20);
			Console.WriteLine(circleSqware.Calculator((double radius) => 
			{

				return Math.PI * radius * radius;
			}));
		
		}

	}
}
