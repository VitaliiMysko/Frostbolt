using ConsoleRestaurant.Application;
using System;

namespace Frostbolt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in the restaurant console application v1.0");

            var app = new Workflow();
            app.Run();
        }
    }
}
