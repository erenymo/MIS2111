using System;
namespace Week_9
{
	// !! A class can't inherit more than one class BUT can inherit more than one interface !!
	public class MachineA:Machine,IMachineStartStop, IMachineSettings, IMaintenance, IPerformance, IShift // A class can inherit more than one interface
	{
		public void Start()
		{
			this.working = true;
			Console.WriteLine("Machine A started.");
		}

		public void Stop()
		{
            this.working = false;
            Console.WriteLine("Machine A stopped.");
		}

		public void SetTheMachine()
		{
            Console.WriteLine("Machine A settings is changed.");
        }

		public void CleanMemory()
		{
			Console.WriteLine("Machine A memory is cleaned.");
		}

		public void Update() // comes with IUpdate in IMaintenance
		{
			Console.WriteLine("Machine A is updated");
		}

		void IPerformance.Report()
		{
			Console.WriteLine("Machine A performance report");
		}

		void IShift.Report()
		{
			Console.WriteLine("Machine A shift report");
		}
	}
}

