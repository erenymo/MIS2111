using System;
namespace Week_6
{
	public class Student:Person
	{
		public float GPA;

        public Student()
        {
            GPA = 0.0f;
            Console.WriteLine("Student class default constructor");
        }

        public Student(string name, int ID, float GPA, int age, string gender):base(age) // calling parent class constructor
        {
            this.GPA = GPA;
            this.ID = ID;
            this.Name = name;
            this.gender = gender;
            Console.WriteLine("student class custom constructor");
        }

        public override void Report()
        {
			Console.WriteLine($"Student Report");
            base.Report(); // calling any method from base class. (it will call the original version of Report, not override version.)
            Console.WriteLine($"GPA: {this.GPA}");
        }

		public void RegisterCourses()
		{
			Console.WriteLine("MATH101, MIS2103");
		}
    }
}

