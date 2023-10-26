namespace Week_4;
class Program
{
    static void Main(string[] args)
    {
        #region Part_1
        /*
        // OBJECT CLASS SAMPLE
        Sample x = new Sample();
        //Console.WriteLine(x.ToString());

        // BOXING UNBOXING
        int y = 42;
        object z = y; // boxing (int to object)
        int q = (int)z; // unboxing (object to int)


        Player myPlayer = new Player("Eren", 4235345);
        Color myColor = new Color();


        //Console.WriteLine($"myPlayer is Color : {myPlayer is Color}");
        //Console.WriteLine($"myPlayer is Player : {myPlayer is Player}");
        //Console.WriteLine($"myPlayer is Object : {myPlayer is Object}");


        // Pattern Matching (creating copy of the object and can be use inside in if block)
        if (myPlayer is Player copyOfMyPlayer)
        {
            //copyOfMyPlayer.Report();
        }

        object objCopy = myColor;

        switch(objCopy)
        {
            case Player playerCopy:
                Console.WriteLine("It's type is player");
                playerCopy.Report();
                break;
            case Color colorCopy:
                Console.WriteLine("It's type is color");
                break;
            case Sample sampleCopy:
                Console.WriteLine("It's type is sample");
                break;
            default:
                Console.WriteLine("It's type is not color or player");
                break;
        }
        */
        #endregion

        #region PART_2
        /*
         * 
        // as keyword
        Player myPlayer = new Player("Eren", 4235345);
        Color myColor = new Color();

        object myObject = myPlayer;

        Console.WriteLine($"myObject is Player : {myObject is Player}");
        Console.WriteLine($"myObject is Player : {myObject is Color}");
        Console.WriteLine("--------");

        Player myPlayerCopy = myObject as Player;
        Color myColorCopy = myObject as Color;

        Console.WriteLine($"myPlayerCopy is not null: {myPlayerCopy is not null}");
        Console.WriteLine($"myColorCopy is not null: {myColorCopy is not null}");


        Player myPlayerCopy2;
        Color myColorCopy2;

        if (myObject is Player)
        {
            myPlayerCopy2 = myObject as Player;
        }
        */
        #endregion

        #region ENUM
        /*
        //ENUM limiting the options of variable
        Player player1 = new Player("Eren", 12355667, Level.Level2);
        player1.Report();
        player1.level = Level.Level3;

        // converting to string
        Console.WriteLine($"{Level.Level1} : {(ushort)Level.Level1}");
        Console.WriteLine($"{Level.Level2} : {(ushort)Level.Level2}");
        Console.WriteLine($"{Level.Level3} : {(ushort)Level.Level3}");
        Console.WriteLine($"{Level.Level4} : {(ushort)Level.Level4}");
        Console.WriteLine($"{Level.Level5} : {(ushort)Level.Level5}");
        */
        #endregion

        #region STRUCT
        /*
        Coordinate myCoordinate = new Coordinate();
        //myCoordinate.Report();

        Coordinate myCoordinate2 = myCoordinate;
        myCoordinate2.x = 77;
        myCoordinate2.y = 77;
        myCoordinate2.z = 77;

        // value type olunca birbirinden bağımsız olurlar. (structlar stack'te(value type) bulunurlar)
        // reference type olunca objenin aslını değiştirirler (classlar heap'te(reference type) bulunurlar)

        Console.WriteLine($"My Coordinate 1: "); // struct olunca objenin kopyasını oluşturup değiştiriyor 0,0,0 ; class olunca direkt objeyi değiştiriyor 77,77,77
        myCoordinate.Report();

        Console.WriteLine($"My Coordinate 2: ");
        myCoordinate2.Report();

        //RecursiveMethod();*/
        #endregion

        #region TUPLE
        // TUPLE are value type
        
        (int x, int y, int z) myTuple = (1, 2, 3);
        Console.WriteLine($"X:" + myTuple.x);
        Console.WriteLine($"Y:" + myTuple.y);
        Console.WriteLine($"Z:" + myTuple.z);

        (int, int, int) mySecondTuple = TupleSim();

        Console.WriteLine($"mySecondTuple : {mySecondTuple}");

        #endregion
    }

    static (int,int,int) TupleSim()
    {
        return (1,2,3);
    }

    /*static void RecursiveMethod()
    {
        Coordinate newCoordinate = new Coordinate();

        RecursiveMethod();
    }*/
}
