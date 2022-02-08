using ConsoleRestaurant.Domain.Interfaces;
using System;

namespace ConsoleRestaurant.Infrastructure.Outputs
{
    public class OutputApp : IOutput
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
