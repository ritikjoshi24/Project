using System;
namespace Project
{
    public class View
    {
        string ground;
        string rock;
        public View()
        {
            ground = ".";
            rock = "#";
        }
        public void dot()
        {
            Console.Write(".");
        }
        public void Line()
        {
            Console.WriteLine();
        }
        public void Ground()
        {
            Console.Write(ground);
        }
        public void Rock()
        {
            Console.Write(rock);
        }
    }
}