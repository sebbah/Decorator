using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mercedes = new Mercedes();
            Console.WriteLine("Car price : {0}", mercedes.Price());

            mercedes = new WheelsDecorator(mercedes);
            Console.WriteLine("Car price with additional wheels: {0}", mercedes.Price());

            Console.ReadKey();
        }
    }
}
