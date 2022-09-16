using System;


namespace ConsoleApp1
{


     partial class Program
    {
        public class vehicle
        {
            public vehicle()
            {
                Console.WriteLine(" Vehicle is being initalized");
            }
        }
    }
}
     public class Car : vehicle
    {
        public Car()
        {
            Console.WriteLine("Car is being initalized ");
        }
    }
}
