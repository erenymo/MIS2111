using System;

namespace week_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person("Ahmet",123456,new DateOnly(2000,7,13));
            //Product prod1 = new Product("Pencil",12.7f);
            //SaveDatabase(person1);
            //SaveDatabase(prod1);

            //person1.Name = "Ahmet";
            //person1.Id = 123456;
            //person1.BirthDate = new DateOnly(2000, 7, 13);
            Person person1 = new Person("Ahmet", 123456, new DateOnly(2000, 7, 13)); // immutable. you cannot change the values after initializing but you can create a copy of them. 

            Person person3 = new Person("Ahmet", 123456, new DateOnly(2000, 7, 13));

            PersonRecord person2 = new PersonRecord("Mehmet", 456, new DateOnly(1999, 6, 10));

            PersonRecord person4 = new PersonRecord("Mehmet", 456, new DateOnly(1999, 6, 10));

            PersonRecord person5 = new PersonRecord("Mustafa", person2.id, person2.birthDate);

            PersonRecord person6 = person2 with { name = "Sıtkı" };

            Console.WriteLine($"Person1==Person3 result: {person1.Equals(person3)}");
            // == operator checks the equality for references

            Console.WriteLine($"Person2==Person4 result: {person2.Equals(person4)}");
            // == operator checks the equality for properties in records


        }

        /*static void SaveDatabase(IReport obj)
        {
            Console.Write("Writing to the database: ");
            Console.WriteLine(obj.Report());
        }

        static void SaveDatabase2(Product obj)
        {
            Console.Write("Writing to the database: ");
            Console.WriteLine(obj.Report());
        }*/
    }
}
