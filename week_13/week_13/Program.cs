namespace week_13;
class Program
{
    static void Main(string[] args)
    {

        Coordinate1 coordA = new Coordinate1();
        coordA.X = 15;
        coordA.Y = 25;
        coordA.Z = 42;

        Coordinate2 coordB = new Coordinate2();
        coordB.X = 12.0f;
        coordB.Y = 24.0f;
        coordB.Z = 11.0f;

        Coordinate<int> coordC = new Coordinate<int>();
        coordC.X = 15;
        coordC.Y = 12;
        coordC.Z = 89;

        Coordinate<float> coordD = new Coordinate<float>();
        coordD.X = 15;
        coordD.Y = 12;
        coordD.Z = 89;

        int x = 42;
        int y = 101;

        Console.WriteLine($"X: {x}");
        Console.WriteLine($"Y: {y}");

        Console.WriteLine("-------------");
        Swap(ref x, ref y);

        Console.WriteLine($"X: {x}");
        Console.WriteLine($"Y: {y}");

        Console.WriteLine("----FLOAT----");

        float e = 12.0f;
        float r = 49.25f;

        Console.WriteLine($"X: {e}");
        Console.WriteLine($"Y: {r}");

        Console.WriteLine("-------------");
        Swap(ref e, ref r);

        Console.WriteLine($"X: {e}");
        Console.WriteLine($"Y: {r}");
    }

    /*
    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    */

    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}

