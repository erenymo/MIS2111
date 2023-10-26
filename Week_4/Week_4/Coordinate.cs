using System;
namespace Week_4
{
	internal struct Coordinate
	{
		public int x = 0;
		public int y = 0;
		public int z = 0;

		public Coordinate()
		{
			this.x = 0;
			this.y = 0;
			this.z = 0;
		}

		public Coordinate(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public void Report()
		{
			Console.WriteLine($"X: {this.x}");
            Console.WriteLine($"Y: {this.y}");
            Console.WriteLine($"Z: {this.z}");

        }
    }
}

