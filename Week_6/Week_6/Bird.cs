using System;
namespace Week_6
{
	public class Bird:Animal
	{
		public Bird()
		{
            Console.WriteLine("Bird class instantiated");
        }

		public void Sing()
		{
            Console.WriteLine("Bird is singing");
        }

        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }
}
