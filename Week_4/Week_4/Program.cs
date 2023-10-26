namespace Week_4;
class Program
{
    static void Main(string[] args)
    {

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
    }
}
