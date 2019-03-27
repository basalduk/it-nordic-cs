using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork11
{

	public class Pet
	{
		public string Kind;
		public string Name;
		public string Sex;
		public DateTimeOffset DateOfBirh;

		public int Age
		{
			get
			{
				TimeSpan age = DateTimeOffset.UtcNow.Subtract(DateOfBirh);
				return Convert.ToInt32(Math.Floor(age.TotalDays / 365.242));
			}

		}
		public string Description
		{
			get { return $"{Name} is a {Kind} ({Sex}) of {Age} years old"; }
		}

		public string ShortDescription
		{
			get { return $"{Name} is a {Kind}"; }
		}
		public void WriteDescription(bool showFullDescription = false)
		{
				Console.WriteLine(showFullDescription
					? Description
					: ShortDescription);
			}
		}

	}
}

