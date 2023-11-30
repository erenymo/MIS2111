namespace Week_9;
class Program
{
    static void Main(string[] args)
    {
        MachineA machine1 = new MachineA(); // its type is also IMachnieStartStop because MachineA inherited the interface.
        MachineB machine2 = new MachineB(); // its type is also IMachnieStartStop because MachineB inherited the interface.
        //IMachineStartStop machine3 = new IMachineStartStop(); // You cannot instantiate interface

        IMachineStartStop machine4 = new MachineA(); // sadece IMachineStartStop'taki bilgilere erişebilir.

        StartMachine(machine1);
        StartMachine(machine2);
        //StartMachineB(machine2);
        Console.WriteLine("--------");

        IMachineStartStop ref1 = machine1;
        IMachineSettings ref2 = machine1;
        Machine ref3 = machine1;

        machine1.ReportStatus();
        ref1.Start();
        ref2.SetTheMachine();
        ref3.ReportStatus();

        Console.WriteLine("--------");

        IShift iShiftRef = machine1;
        iShiftRef.Report();

        IPerformance iPerfRef = machine1;
        iPerfRef.Report();

        Console.WriteLine("--------");


        Console.WriteLine($"Machine1 is IMachine... {machine1 is IMachineStartStop}");
        Console.WriteLine($"Machine2 is IMachine... {machine2 is IMachineStartStop}");

        Console.WriteLine("--------");

        StopMachine(machine1);
        StopMachine(machine2);

    }

    static void StartMachine(IMachineStartStop machine)
    {
        machine.Start();
    }

    static void StopMachine(IMachineStartStop machine)
    {
        machine.Stop();
    }

    /*
    static void StartMachineB(MachineB machine)
    {
        machine.Start();
    }
    */
}