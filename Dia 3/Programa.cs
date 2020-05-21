using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        struct Santa
        {
            public int x, y;
        }
        struct Robot
        {
            public int rx, ry;
        }

        static void Main(string[] args)
        {
            string f = "";
            f = File.ReadAllText("Dia 3.txt");

            int i, x, y, rx, ry;
            char ch;
            int n = 1;
            int r = 0;
            int total = 0;
            rx = 0;
            ry = 0;
            x = 0; 
            y = 0;


            Santa[] parray = new Santa[0];
            Robot[] rarray = new Robot[0];
            Santa point;
            Robot rpoint;
            rpoint.rx = rx;
            rpoint.ry = ry;
            point.x = x;
            point.y = y;
            

            for (i = 0; i < f.Length; i++)
            {
                ch = f.Substring(i, 1).ToCharArray()[0];

                if (i % 2 == 0)
                {
                    switch (ch)
                    {
                        case '<':
                            x--;
                            break;
                        case '>':
                            x++;
                            break;
                        case '^':
                            y++;
                            break;
                        case 'v':
                            y--;
                            break;
                    }

                    point.x = x;
                    point.y = y;

                    Console.WriteLine($"parray[{i}]: x = {point.x}; y = {point.y}\n");

                    if (Array.IndexOf(parray, point) == -1)
                    {
                        n++;
                        Array.Resize(ref parray, n);
                        parray[n - 1] = point;
                    }
                }
                else
                {
                    switch (ch)
                    {
                        case '<':
                            rx--;
                            break;
                        case '>':
                            rx++;
                            break;
                        case '^':
                            ry++;
                            break;
                        case 'v':
                            ry--;
                            break;
                    }

                    rpoint.rx = rx;
                    rpoint.ry = ry;

                    Console.WriteLine($"rarray[{i}]: x = {rpoint.rx}; y = {rpoint.ry}\n");


                    if (Array.IndexOf(rarray, rpoint) == -1)
                    {
                        r++;
                        Array.Resize(ref rarray, r);
                        rarray[r - 1] = rpoint;
                    }
                }
            }

                

            i = -1;
            Console.WriteLine($"Número de casas que receberam presentes do Pai Natal: " + parray.Length);
            Console.WriteLine($"Número de casas que receberam presentes do Robot-Natal: " + rarray.Length);
            total = (parray.Length + rarray.Length);
            Console.WriteLine(@"Número de casas que receberam presentes dos dois: " + total);
            Console.WriteLine(@"Número de visitas totais: " + f.Length);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
