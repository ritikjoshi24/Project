using System;
using System.Collections.Generic;
namespace Project
{
    public class newWorld
    {
        int a;
        int b;
        int d;
        int g;

        string ground = ".";
        string rock = "#";
        View view = new View();
        public newWorld()
        {
            g = 0;
        }
        public void Box(int first, int second, int time)
        {
            Random r = new Random();

            do
            {
                for (a = 0; a < first; a++)
                {
                    view.Line();
                    for (b = 0; b < second; b++)
                    {
                        d = r.Next(0, 2);
                        if (d == 0)
                        {
                            view.Ground();
                        }
                        else if (d == 1)

                        {
                            view.Rock();
                        }
                    }
                }
                g++;


            } while (g <= time);

            Console.WriteLine(time);
            Console.WriteLine(g);
        }
    }
}