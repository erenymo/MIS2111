namespace Week2;
class Program
{
    static void Main(string[] args)
    {
        #region first_part
        /*
        Player player1 = new Player();
        player1.x = 1.0f;
        player1.y = 2.0f;
        player1.z = 3.0f;
        // . operator is used to reach the element inside of an object

        Player player2 = new Player();
        player2.x = 2.0f;
        player2.y = 1.0f;
        player2.z = 5.0f;

        DefaultValues myDefaultValues = new DefaultValues();
        Console.WriteLine($"Default integer : {myDefaultValues.anInt}");
        Console.WriteLine($"Default float : {myDefaultValues.aFloat}");
        Console.WriteLine($"Default bool : {myDefaultValues.aBool}");
        Console.WriteLine($"Default string : {myDefaultValues.aString}");

        Console.WriteLine($"Int default {default(int)}");
        Console.WriteLine($"char default {default(char)}");
        */
        #endregion

        #region second_part

        /*
        Player player3 = new Player();
        Console.WriteLine($"player3 x : {player3.x}");
        Console.WriteLine($"player3 y : {player3.y}");
        Console.WriteLine($"player3 z : {player3.z}");
        Console.WriteLine("---------------");

        Player player4 = new Player(4.2f, 7.0f, 6.0f);
        Console.WriteLine($"player4 x : {player4.x}");
        Console.WriteLine($"player4 y : {player4.y}");
        Console.WriteLine($"player4 z : {player4.z}");

        Player player5 = new Player(1.0f, 2.0f, 3.0f);
        //player5.x = 2.0f;
        player5.Report();

        float x = player5.GetX();
        float y = player5.GetY();
        float z = player5.GetZ();

        // Deconstructor 
        (float x2, float y2, float z2) = player5;
        Console.WriteLine($"x, y, z from deconstruct: {x2}, {y2}, {z2}");
        */
        #endregion

        // Static Members (can be called without object initialization. Ayrıca içinde bulundukları class ın özelliklerine erişemezler)

        /*Player player10 = new Player();
        Console.WriteLine($"Player quantity : {Player.playerQty}");
        Console.WriteLine("---");

        Player player11 = new Player();
        Console.WriteLine($"Player quantity : {Player.playerQty}");

        Player.FirstStaticMethod();*/

        // Anonymous Classes
        /*var myAnonymousClass = new { name = "Eren", surname = "Balta"};
        Console.WriteLine($"Name : {myAnonymousClass.name}");
        Console.WriteLine($"Surname : {myAnonymousClass.surname}");*/

        Player player20 = new Player();
        Player player21 = new Player(1.0f, 2.0f);
        Player player22 = new Player(1.1f, 2.1f, 3.3f);
        Player player23 = new Player(2.0f, 7.0f, 12.0f, "Not used in the object");
    }
}
