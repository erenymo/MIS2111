using System;
namespace Week_4
{
	internal class Player
	{
		public string name;
		public int id;
		public Level level; // level can have 3 values : 1,2,3

		public Player()
		{
			this.name = string.Empty; // same as this.name = "";
			this.id = default(int); // same as this.id = 0;
			//this.level = 1;
			this.level = Level.Level1;
        }

		// Overloading the constructor method
		public Player(string name, int id, Level level)
		{
			this.name = name;
			this.id = id;
			this.level = level;
		}

		public void Report()
		{
			Console.WriteLine($"player name : {this.name}");
            Console.WriteLine($"player id : {this.id}");
			//Console.WriteLine($"player level : {this.level}");
			Console.WriteLine($"Player Level is : {this.level}");
        }
    }
}

