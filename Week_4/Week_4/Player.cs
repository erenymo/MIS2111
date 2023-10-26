using System;
namespace Week_4
{
	internal class Player
	{
		public string name;
		public int id;

		public Player()
		{
			this.name = string.Empty; // same as this.name = "";
			this.id = default(int); // same as this.id = 0;
		}

		// Overloading the constructor method
		public Player(string name, int id)
		{
			this.name = name;
			this.id = id;
		}

		public void Report()
		{
			Console.WriteLine($"player name : {this.name}");
            Console.WriteLine($"player id : {this.id}");
        }
    }
}

