namespace Week_11;
class Program
{
    static void Main(string[] args)
    {
        
        Date myDate = new Date(2021,09,30);

        Console.WriteLine($"{myDate.Year}/{myDate.Month}/{myDate.Day}");

        //myDate.Day = 26;
        //myDate.Month = 9;
        //myDate.Year = 2003;
        Console.WriteLine($"{myDate.Year}/{myDate.Month}/{myDate.Day}");

        Console.WriteLine(myDate); // ToString methodunu çağırır.

        //myDate.Day = -1;
        //myDate.Month = 36;
        Console.WriteLine(myDate.TotalDays);
        Console.WriteLine(myDate);
        

        Time myTime = new Time(13, 45);
        Console.WriteLine(myTime);

        myTime.Hours = 26;
        myTime.Minutes = 98;
        Console.WriteLine(myTime);

        Console.WriteLine(myTime.TotalMinutes);


        Student std1 = new Student("Eren BALTA", 138721019, myDate);
        Console.WriteLine(std1);
    }
}

