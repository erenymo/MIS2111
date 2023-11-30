using System;
namespace Week_9
{
    // !! A class can't inherit more than one class BUT can inherit more than one interface !!
    public class MachineB:Machine,IMachineStartStop, IMachineSettings // A class can inherit more than one interface
    {
        public void Start()
		{
            this.working = true;
			Console.WriteLine("Machine B started.");
		}

		public void Stop()
		{
            this.working = false;
			Console.WriteLine("Machine B stopped.");
		}

        public void SetTheMachine()
        {
            Console.WriteLine("Machine B settings is changed.");
        }

    }
}

