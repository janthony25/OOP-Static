using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // ******** IMPORTANT NOTE **********
            // static = modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object


            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Civic");

            Console.WriteLine(Car.numberOfCars);

            
            Car.StartRace();

            Console.ReadKey();
        }
    }

    class Car
    {
        string model;
        public static int numberOfCars;

        // Constructor
        public Car(string model)
        {
            this.model = model;
            numberOfCars++;
        }

        // static object
        public static void StartRace()
        {
            Console.WriteLine("The race has now begun!");
        }


    }
}