using System;

namespace ConstructorOverloading
{
    class Car
    {
        string Brand;
        int Price;

        //Default Constructor
        public Car()
        {
            Brand = "Maruti";
            Price = 500000;
            Console.WriteLine("The Output Of The Default Constructor:");
            Console.WriteLine();
            Console.WriteLine("The Old Car is {0} and Price is: {1}  ", Brand, Price);
            Console.WriteLine();
        }

        //Parameterized Constructor
        public Car(string name, int NewCarPrice)
        {
            Brand = name;
            Price = NewCarPrice;
            Console.WriteLine("The Output Of The Parameterized Constructor:");
            Console.WriteLine();
            Console.WriteLine("The New Car Is {0} and The Preice is: {1}", Brand, NewCarPrice);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car bp = new Car(); //Default Constructor Called
            Car bp1 = new Car("Honda City", 800000); //Overloaded Constructor.
            Console.ReadLine();
        }
    }
}
