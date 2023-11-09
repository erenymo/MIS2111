using System;
namespace Week_6
{
	public class Person
	{
		// three access modifier : publick, private, protected

		public string Name; // they can visible because public
		public int ID;

		private int age; // cannot visible because private

		protected string gender; // it is going to be visible in child classes but invisible in any other class.

		public Person()
		{
			Name = "";
			ID = 0;
			this.age = 0;
			this.gender = "female";
            Console.WriteLine("Person class default constructor");

        }

        public Person(string name, int ID)
		{
			this.Name = name;
			this.ID = ID;
			//this.age = age;
		}

		public Person(int age)
		{
			this.age = age;
			Console.WriteLine("Person constructor with age setting");
		}

		public virtual void Report()
		{
			Console.Write($"Name : {this.Name} , ID : {this.ID},  Age: {this.age} ");
		}

	}
}

