using System;
using System.Collections.Generic;
namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            int time;
            newWorld newWorld = new newWorld();
            Int32.TryParse(Console.ReadLine(), out first);
            Int32.TryParse(Console.ReadLine(), out second);
            Int32.TryParse(Console.ReadLine(), out time);
            newWorld.Box(first, second, time);
        }
    }
}
