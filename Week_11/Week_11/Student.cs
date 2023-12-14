using System;
namespace Week_11
{
	public class Student
	{
		private string _studentName;
		private int _studentID;
		private Date _registerDate;

		public Student(string studentName, int studentID, Date registerDate)
		{
			this.StudentName = studentName;
			this.StudentID = studentID;
			this.RegisterDate = registerDate;
		}

		public string StudentName
		{
			get { return _studentName; }
			init { this._studentName = value; } // init: bir kere ayarladıktan sonra bir daha değiştirilemez
		}

		public int StudentID
		{
			get { return _studentID; }
			init { this._studentID = value; }
		}

		public Date RegisterDate
		{
			get { return _registerDate; }
			init { this._registerDate = value; }
		}

        public override string ToString()
        {
            return $"Student Name: {this.StudentName}\nStudent ID: {this.StudentID}\nRegistration Date: {this.RegisterDate}";
        }

    }
}

