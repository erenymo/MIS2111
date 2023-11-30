using System;
namespace Week_9
{
	public class Machine
	{
        public bool working = false;

        public void ReportStatus()
        {
    
                Console.WriteLine($"Machine status : {this.working}");
            
        }
    }
}

