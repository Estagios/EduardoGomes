using System;
using System.IO;

namespace Dia_2_alternativo
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var fileContent = File.ReadAllLines(@"Dia 2.txt");
                MeuAlgo(fileContent);
            }
        }

        private static void MeuAlgo(string[] fileContent)
        {
            int l = 0;
            int w = 0;
            int h = 0;
            int min2 = 0;
            int min = 0;
            long soma = 0;
            int area = 0;



            foreach (var line in fileContent)
            {
                l = 0;
                w = 0;
                h = 0;

                var aux = line.Split('x');
                l = Int32.Parse(aux[0]);
                w = Int32.Parse(aux[1]);
                h = Int32.Parse(aux[2]);

                if ((l < w) && (l < h))
                {
                    area = l;
                }

                if ((w < l) && (w < h))
                {
                    area = w;
                }

                if ((h < w) && (h < l))
                {
                    area = h;
                }


                soma += ((2 * l * w) + (2 * w * h) + (2 * h * l)) + area;

            }
            
            Console.WriteLine("Square feet of wrapping paper needed: " + soma);

            Console.ReadKey();
        }
    }
}
