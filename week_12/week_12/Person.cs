using System;
namespace week_12
{
	public class Person
	{
		public string Name { get; init; } // init keyword: sets the value only one time while initializing the class.
		public int ID { get; init; }
		public DateOnly BirthDate { get; init; }

		public Person(string name, int id, DateOnly birthDate)
		{
			this.Name = name;
			this.ID = id;
			this.BirthDate = birthDate;
		}

        public override string ToString()
        {
            return $"Person {{Name = {this.Name}, ID = {this.ID}, Birth Date = {this.BirthDate} }}";
        }

    }
}

