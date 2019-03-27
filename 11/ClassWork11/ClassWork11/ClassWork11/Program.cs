using System;

namespace ClassWork11
{
	class Program
	{
		static void Main(string[] args)
		{
			Pet pet1 = new Pet
			{
				Kind = "Котенок",
				Name = "кыс-кыс",
				Sex = "male",
				DateOfBirh = DateTimeOffset.Parse("2018-01-01"),
			};
			pet1.WriteDescription(false);

			Pet pet2 = new Pet();
			pet2.Kind = "Собака";
			pet2.Name = "Шарик";
			pet2.Sex = "male";
			pet2.DateOfBirh = DateTimeOffset.Parse("2018-01-01");
			pet2.WriteDescription(true);


			Console.WriteLine("Kind : {0}, Name: {1}, Sex{2}, Age : {3})", pet1.Kind, pet1.Name, pet1.Sex, pet1.Age);
			Console.WriteLine("Kind : {0}, Name: {1}, Sex{2}, Age : {3})", pet2.Kind, pet2.Name, pet2.Sex, pet2.Age);



		}
		//static void Main(string[] args)
		//{

		//	Random rand = new Random();
		//	int r = rand.Next();
		//	Console.WriteLine("Hello World!");
		//}
		//public string PropertiesString 
		//{
		//	get { return "выапавп"; }
		//}

		//public string PropertiesStringmetod()
		//{
		//	 return "выапавп";
		//}


	}
}
