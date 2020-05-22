using System;
using System.IO;

namespace Dia_2_alternativo
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var fileContent = File.ReadAllLines(@"Dia 2 Example1.txt");
                MeuAlgo(fileContent);
                Console.WriteLine("\tResultado tem de ser: " + 58);
            }
            {
                var fileContent = File.ReadAllLines(@"Dia 2 Example2.txt");
                MeuAlgo(fileContent);
                Console.WriteLine("\tResultado tem de ser: " + 43);
            }
            {
                var fileContent = File.ReadAllLines(@"Dia 2 Example1+2.txt");
                MeuAlgo(fileContent);
                Console.WriteLine("\tResultado tem de ser: " + (43+58));
            }
            {
                var fileContent = File.ReadAllLines(@"Dia 2.txt");
                MeuAlgo(fileContent);
            }
            
            Console.WriteLine("- clica numa tecla para fechar -");
            Console.ReadKey();
        }

        private static void MeuAlgo(string[] fileContent)
        {
            var soma = 0;

            foreach (var line in fileContent)
            {
                var l = 0;
                var w = 0;
                var h = 0;
                var area = 0;

                var aux = line.Split('x');
                l = Int32.Parse(aux[0]);
                w = Int32.Parse(aux[1]);
                h = Int32.Parse(aux[2]);

                if ((l > w) && (l > h))
                {
                    area = w * h;
                }

                if ((w > l) && (w > h))
                {
                    area = l * h;
                }

                if ((h > w) && (h > l))
                {
                    area = w * l;
                }


                soma += (2 * l * w + 2 * w * h + 2 * h * l) + area;

            }
            
            Console.WriteLine("Square feet of wrapping paper needed: " + soma);
        }
    }
}
