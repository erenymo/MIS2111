using System;
namespace Week_3
{
	public class Student
	{
		// public variables starts with uppercase
		public string Name;
		public int StdNumber;

		public Student()
		{
			Name = "Not Provided";
			StdNumber = 0;
		}

		public Student(string name, int stdNumber)
		{
			this.Name = name;
			this.StdNumber = stdNumber;
		}

		public void Report()
		{
			Console.WriteLine($"Student name : {this.Name}");
            Console.WriteLine($"Student number : {this.StdNumber}");

        }
    }
}

