using System;

namespace ClassWork12
{
	class Program
	{
		static void Main(string[] args)

		{
			BaseDocument[] newbase = new BaseDocument[5];
			newbase[1] = new BaseDocument { DocName = "document", DocNumber = "1", IssueDate = DateTimeOffset.Parse("01/04/2019") };
			newbase[2] = new Passport { DocName = "Passport", DocNumber = "2", IssueDate = DateTimeOffset.Parse("01/04/2019") };
			newbase[3] = new BaseDocument { DocName = "document", DocNumber = "3", IssueDate = DateTimeOffset.Parse("01/04/2019") };
			newbase[4] = new Passport { DocName = "Passport", DocNumber = "4", IssueDate = DateTimeOffset.Parse("01/04/2019") };
			newbase[5] = new BaseDocument { DocName = "document", DocNumber = "5", IssueDate = DateTimeOffset.Parse("01/04/2019") };





			foreach (var BaseDocuments in newbase)
			{
				if (newbase == Passport{ })
				{ }
			}

			//BaseDocument doc = new BaseDocument
			//{
			//	DocName = "document",
			//	DocNumber = "1",
			//	IssueDate = DateTimeOffset.Parse("01/04/2019"),
			//};

			//Passport pass = new Passport
			//{
			//	DocName = "document",
			//	DocNumber = "1",
			//	IssueDate = DateTimeOffset.Parse("01/04/2019 08:00:00"),
			//	Country = "Russia",
			//	PersonName = "Mikhail"
			//};

			//doc.WriteToConsole();
			//pass.WriteToConsole();


		}
	}
	
}
