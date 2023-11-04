namespace Week_5;
class Program
{
    static void Main(string[] args)
    {
        #region FIRST_PART
        /*
        // declaring a bool array that all elements are bool type.
        bool[] data = new bool[5];

        foreach(bool i in data)
        {
            //Console.WriteLine(i);
        }

        for(int i = 0; i < data.Length; i++)
        {
            //Console.WriteLine(data[i]);
        }
        

        
        Student[] students = new Student[5];

        students[0] = new Student("Eren", "1");
        students[1] = new Student("Şule", "2");
        students[2] = new Student("Aydın", "3");
        students[3] = new Student("Töre", "4");
        students[4] = new Student("Nurul", "5");

 
        for (int i = 0; i < students.Length;i++) {
            Console.WriteLine($"------Student Info {i + 1}------");
            students[i].Report();
        }

        
        int[][] data = new int[3][];
        data[0] = new int[3];
        data[1] = new int[2];
        data[2] = new int[4];

        Random rnd = new Random();
        rnd.Next();

        // You cannot iterate any variable in foreach loop because it is only read-only loop. Use for loop.
        
        foreach (int[] items in data)
        {
            foreach(int item in items)
            {
                item = rnd.Next();
            }
        }

        for(int i = 0; i < data.Length; i++)
        {
            Console.WriteLine($"-----Array {i + 1}-----");
            for(int j = 0; j < data[i].Length; j++)
            {
                data[i][j] = rnd.Next() % 1000;
                Console.WriteLine(j + " " + data[i][j]);
            }
        }
        */
        #endregion


        #region SECOND_PART
        /*
        Console.WriteLine($"12 + 24 + 42 = {Utilities.Add(12, 24, 42)}");

          int[] numbers = new int[10];

        Random rnd = new Random();

        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next() % 100;
        }

        for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} + ");
        }
        Console.WriteLine($" \n= {Utilities.Add(numbers)}");
        Console.WriteLine("---params keyword----");

        int sum2 = Utilities.Add(10, 20, 30, 40);
        Console.WriteLine(sum2);


        int sum = Utilities.Add(10, 20, 30, 40, 50, 60);
        Console.WriteLine(sum);
        */
        #endregion

        Bird myBird = new Bird();
        Dog myDog = new Dog();

        myBird.Breathe();
        myBird.Eat();

        myDog.Breathe();
        myDog.Eat();
    }
}

