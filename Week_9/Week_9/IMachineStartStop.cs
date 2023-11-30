using System;
namespace Week_9
{
	// Interfaces can only inherit from other interfaces.
	public interface IMachineStartStop
	{
		// Interface name should start with I.
		// you cannot declare variables, constructor

		// you can only define method signatures (!! methods in interface are always public !!)
		void Start();
		void Stop();

		// you can also define method with body. (not recommended, don't use)
		void DoSomething()
		{
			Console.WriteLine("Machine doing something");
		}
	}
}

