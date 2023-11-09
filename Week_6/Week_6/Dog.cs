using System;
namespace Week_6
{
	public class Dog:Animal // When you inherit one class(Animal), the inherited class(Animal) also created when you create Dog class.
	{
		public Dog()
		{
            Console.WriteLine("Dog class instantiated");

        }

        public void Bark()
		{
			Console.WriteLine("Woof Woof");
		}

        public void Run()
        {
            Console.WriteLine("Dog is running");
        }

        /*
        // Changing the implementation. (Eat class also belongs to Animal Class)
        new public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
        */

        public override void Eat()
        {
            Console.WriteLine("Dog is eating");
        }

    }
}

