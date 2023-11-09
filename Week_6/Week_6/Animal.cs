using System;
namespace Week_6
{
	public class Animal
	{
		public Animal()
		{
            Console.WriteLine("Animal class instantiated");
		}

        public void Breathe()
        {
            Console.WriteLine("Breathing");
        }

        public virtual void Eat() // we use virtual keyword only in first definition. When you override this method, it affects the original method.
        {
            Console.WriteLine("Eating really fast");
        }
    }
}

