using System;
namespace Week2
{
	// All class names should be start with Uppercase.
	internal class Player
	{
		/*
		 * Public Variables start with uppercase : PlayerQty
		 * private variables start with lowercase (sometimes add _ to the beginning) : _coordX, _coordY, _coordZ 
		public float x;
		public float y;
		public float z;
		*/

		// encapsulation (hide elements to the outside, make them accessible only from inside.)

		// Field : all variables that defined in class
		private float x;
		private float y;
		private float z;

		// Static Members
		public static int playerQty; // it exist independently in static memory, not heap or stack

		// Constructor without parameters
		public Player() // Constructor name should be the same as class name
		{
			this.x = 7.0f;
			this.y = 7.0f;
			this.z = 7.0f;
			Player.playerQty += 1; // How to change static variable

            Console.WriteLine("default constructor");
        }

        public Player(float x, float y)
        {
            this.x = x;
            this.y = y;
            this.z = 10.0f;

            Console.WriteLine("2 arguments constructor");
        }

        // Constructor with parameters
        public Player(float x,float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
            Player.playerQty += 1;

            Console.WriteLine("3 arguments constructor");
        }

        public Player(float x, float y, float z, string message)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            Player.playerQty += 1;

            Console.WriteLine("4 arguments constructor");
			Console.WriteLine(message);
        }

        // Method names should start with Uppercase
        public void Report()
		{
			Console.WriteLine($"Coordinates of the player : (x:{this.x}, y:{this.y}, z:{this.z})");
		}

		// Getters
		public float GetX()
		{
			return this.x;
		}

        public float GetY()
        {
            return this.y;
        }

        public float GetZ()
		{
			return this.z;
		}

		// Deconstructor
		public void Deconstruct(out float x, out float y, out float z)
		{
			x = this.x;
			y = this.y;
			z = this.z;
		}

		// Static Method (this keyword is not available for static members)
		public static void FirstStaticMethod()
		{
			Console.WriteLine("Hello from static method");	
		}
	}
}