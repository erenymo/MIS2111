namespace week_14;
class Program
{
    static void Main(string[] args)
    {
        /*
        #region FirstPART
        // List is a generic type
        Console.WriteLine("---myList---");
        List<int> myList = new List<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Add(5);
        myList.Add(6);
        myList.Add(5);
        myList.Add(7);
        myList.Add(5);
        myList.Add(5);
 
        ReportMethod(myList);

        Console.WriteLine("---Remove Method--");
        myList.Remove(5); // ilk karşılaştığı 5'i siler.

        ReportMethod(myList);

        Console.WriteLine("---RemoveAt Method---");
        myList.RemoveAt(0); // 0. index'teki elemanı sil.
        ReportMethod(myList);

        Console.WriteLine($"Capacity Method: {myList.Capacity}");
        Console.WriteLine($"Count Method: {myList.Count}");

        List<int> myList2 = new List<int>(50);
        myList2.Add(4);
        Console.WriteLine($"Capacity Method: {myList2.Capacity}");
        Console.WriteLine($"Count Method: {myList2.Count}");


        Console.WriteLine("###  QUEUE  ###");
        Queue<int> myQueue = new Queue<int>();
        myQueue.Enqueue(77);
        myQueue.Enqueue(96);
        myQueue.Enqueue(45);
        myQueue.Enqueue(99);
        myQueue.Enqueue(15);

        Console.WriteLine($"Count : {myQueue.Count}");

        Console.WriteLine($"Dequed : {myQueue.Dequeue()}"); // removes the first element on queue and returns it
        Console.WriteLine($"Count : {myQueue.Count}");
        Console.WriteLine("###  STACK  ###");

        Stack<int> myStack = new Stack<int>();
        myStack.Push(78);
        myStack.Push(64);
        myStack.Push(17);
        myStack.Push(22);

        Console.WriteLine($"{myStack.Count}");
        Console.WriteLine($"Pop : {myStack.Pop()}"); // removes the last element in stack and returns it
        Console.WriteLine($"{myStack.Count}");


        Console.WriteLine("###  DICTIONARY  ###");
        // instead of reaching the element with indexes, we use a key-value structure.

        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages.Add("eren", 21); // eren is key, 21 is value
        ages.Add("ahmet", 34);
        ages.Add("mehmet", 15);
        ages.Add("fatma", 17);

        Console.WriteLine($"Ahmet age : {ages["eren"]}");
        Console.WriteLine($"Ahmet age : {ages["ahmet"]}");
        Console.WriteLine($"Ahmet age : {ages["mehmet"]}");
        Console.WriteLine($"Ahmet age : {ages["fatma"]}");

        // To Practice these : 
        // Try to code stack and queue data structure in yourself to practice. (you can mention the capacity at least 100 to make it easy)
        // take a look at HashSet<>
        #endregion
        */

        // OPERATOR OVERLOADING
        MyComplex number1 = new MyComplex(2, 10);
        MyComplex number2 = new MyComplex(3, 7);

        Console.WriteLine(number1);
        Console.WriteLine(number2);

        MyComplex number3 = number1 + number2;
        Console.WriteLine(number3);

        MyComplex number4 = number2 - number1;
        Console.WriteLine(number4);

        number4++;

        Console.WriteLine(number4);

        //int x = (int)number4; //explicit
        int x = number4; // implicit

        Console.WriteLine(x);

        MyComplex number5 = new MyComplex(number4.Real, number4.Imaginary);

        Console.WriteLine(number5 == number4);
        Console.WriteLine(number5 != number4);

        ++number4;

        Console.WriteLine(number5 == number4);
        Console.WriteLine(number5 != number4);

    }

    private static void ReportMethod(List<int> myList)
    {
        
        foreach (var i in myList)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine($"\n\n");
    }
}

