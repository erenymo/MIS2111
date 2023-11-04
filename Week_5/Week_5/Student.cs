using System;
namespace Week_5
{
	internal class Student
	{
		// Classes are reference type
		public string Name;
		public string ID;

		public Student()
		{
			this.Name = "";
			this.ID = "";
		}

		public Student(string studentName, string studentID)
		{
			this.Name = studentName;
			this.ID = studentID;
		}

		public void Report()
		{
            Console.WriteLine($"Student Name: {this.Name}, Student ID: {this.ID}");
        }
    }
}

