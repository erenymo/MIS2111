namespace Week_3;
class Program
{
    static void Main(string[] args)
    {

        #region First

        
        // heap stack static (tekrar et)

        Console.WriteLine(Sample.PI);

        // const variables cannot change after it is declared
        //Sample.PI = 4.10f;


        // it is not possible to create object from static class
        // Sample obj = new Sample();

        Sample.Report();


        /* VALUE TYPE vs REFERENCE TYPE 

        stack(değer stackte saklanıyorsa value type)
        heap(heapte saklanıyorsa reference type)
         
         */

        Student std1 = new Student();
        Student std2 = new Student("Eren", 138721019);

        std1.Report();
        std2.Report();

        string myString = "Marmara University";

        Student std3 = null;

        int x = 42;

        /* NULLABLE TYPE */
        // use the question mark to convert/declare any type to null
        // stackte saklanan değerler için null değer atanamaz
        int? y = null; // türden sonra ? geldiğinde artık null değer de taşıyabilir demek
        float? z = null;
        bool? a = null;

        y = 101;
        y = null;

        if (std3 != null)
        {
            std3.Report();
        }
        /*else
        {
            Console.WriteLine($"{nameof(std3)} is null");
        }
        */

        // null conditional operator (?)
        std3?.Report(); // if it is not null, call the report. if it is, dont do anything
        std2?.Report();

        if (std3 is not null) // is <=> ==    || is not <=> !=
        {
            std3.Report();
        }

        Console.WriteLine($"std3 is null: {std3 is null}");
        Console.WriteLine($"std3 is not null: {std3 is not null}");

        int? newNullableValue = null;

        if(newNullableValue.HasValue)
        {
            Console.WriteLine($"Y has a value and it's {newNullableValue}");
        } else
        {
            Console.WriteLine($"Y doesn't have a value");

        }

        int? e = 42;
        // int r = e; can't take nullable type 

        int r = 100;
        int? n = r;
        #endregion

        Console.WriteLine("----------------------");


        /* REF AND OUT */

        /*
        int k = 101;
        Console.WriteLine($"Value of y is : {k}");
        MethodThatUsesRef(ref k);
        Console.WriteLine($"Value of y is : {k}");*/

        int k;
        MethodThatUsesOut(out k);
        Console.WriteLine($"Value of y is : {k}");

        // NULL COALESCING OPERATORS

        Student std4 = new Student();
        Student std5 = null;
        Student std6;

        if(std5 is not null)
        {
            std6 = std5;
        } else
        {
            std6 = std4;
        }

        std6 = std5 ?? std4; // if the left operand is not null, then return left operand; if it is, then return right operand

        /*Console.WriteLine("Std4:");
        std4.Report();
        Console.WriteLine("Std6:");
        std6.Report();
        std4.Name = "ABCDEFG";
        Console.WriteLine("Std4:");
        std4.Report();
        Console.WriteLine("Std6:");
        std6.Report();*/

    }

    public static void MethodThatUsesRef(ref int x)
    {
        x += 1;
    }

    public static void MethodThatUsesOut(out int x)
    {
        x = 42;
    }

}