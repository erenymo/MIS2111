namespace Week_6;
class Program
{
    static void Main(string[] args)
    {
        #region FIRST_PART(DOG AND ANIMAL EXAMPLE)
        /*
        Animal myAnimal = new Animal();
        Dog myDog = new Dog();
        myDog.Eat();
        myDog.Breathe();
        myDog.Bark();
        myDog.Run();

        Bird myBird = new Bird();
        myBird.Sing();
        myBird.Fly();
        myBird.Eat();
        myBird.Breathe();

        
        //POLYMORPHISM
        //- Parent class ref can refer child class object
        //- Parent class, Child'e sonradan eklenen methodları ve attribute'leri göremiyor.
        

        Animal myPet = myDog;
        myPet.Eat();

        // Dog myDog2 = myAnimal; // Child class ref cannot refer parent class object.
        */
        #endregion

        Student std1 = new Student("Eren", 32452, 4.0f,21, "male");
        std1.Report();

        Person person = std1;
        person.Report();

        Lecturer l1 = new Lecturer("aydınus prime", 23543245, 6, 36);
        l1.Report();

        int x = 42;
        Console.WriteLine(x);
        x = x.Negate();
        Console.WriteLine(x);      
    }
}

