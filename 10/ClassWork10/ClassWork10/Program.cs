using System;
using System.Collections.Generic;


namespace ClassWork10
{
	class Program
	{
		static void Main(string[] args)
		{
			Pet pet1 = new Pet
			{
			Kind = "животное",
			Name = "кличка",
			Sex = "male",
			Age = 10,
			};

			Pet pet2 = new Pet();
			pet2.Kind = "животное";
			pet2.Name = "кличка";
			pet2.Sex = "male";
			pet2.Age = 10;
			

			Console.WriteLine("Kind : {0}, Name: {1}, Sex{2}, Age : {3})", pet1.Kind,pet1.Name,pet1.Sex,pet1.Age);
			Console.WriteLine("Kind : {0}, Name: {1}, Sex{2}, Age : {3})", pet2.Kind, pet2.Name, pet2.Sex, pet2.Age);

		}
	}

}
