using System;
namespace week_12
{
	public class Person2:IReport
	{
		public string Name { get; set; }
		public int ID { get; set; }
		public DateOnly BirthDate { get; set; }

		public Person2(string name, int id, DateOnly birthDate)
		{
			this.Name = name;
			this.ID = id;
			this.BirthDate = birthDate;
		}

		public string Report()
		{
			return $"Name: {this.Name}";
		}
	}
}

