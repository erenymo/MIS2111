using System;
namespace Week_6
{
	public class Lecturer:Person
	{
		int totalNumOfCourses;

		public Lecturer(string name, int ID, int totalNumOfCourses, int age) : base(age)
		{
			this.Name = name;
			this.ID = ID;
			this.totalNumOfCourses = totalNumOfCourses;
		}

        public override void Report()
        {
			Console.WriteLine("Lecturer Report");
			base.Report();
			Console.WriteLine($"Course Number: {this.totalNumOfCourses}");
        }

        public void CourseSchedule()
		{
			Console.WriteLine("mon: mis2103");
		}
    }
}

