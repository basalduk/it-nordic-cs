using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork12
{
	public class BaseDocument
	{
		public string DocName { get; set; }
		public string DocNumber { get; set; }
		public DateTimeOffset IssueDate { get; set; }

		public virtual string PropertyString
		{
			get { return $"DocName: {DocName}\n DocNumber: {DocNumber}\n IssueDate: {IssueDate}\n"; }
		}

		public void WriteToConsole()
		{
			Console.WriteLine(PropertyString);
		}
	}

	public class Passport : BaseDocument
	{
		public string Country { get; set; }
		public string PersonName { get; set; }
		public override string PropertyString
		{
			get
			{
				return $"DocName: {DocName}\n DocNumber: {DocNumber}\n IssueDate: {IssueDate}\n Country: {Country}\n PersonName: {PersonName}\n";
			}
		}
		public DateTimeOffset ChangeIssueDate(DateTimeOffset newIssueDate)
		{
			return IssueDate = DateTimeOffset.Now;
		}
	}
}