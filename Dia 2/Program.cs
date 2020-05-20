using System;

namespace Dia_2_alternativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 0;
            int w = 0;
            int h = 0;
            string aux;
            int i = 0;
            int count = 0;
            int soma = 0;
            string line;

            string text = System.IO.File.ReadAllText(@"Dia 2.txt");
            System.IO.StreamReader file = new System.IO.StreamReader(@"Dia 2.txt");


            while ((line = file.ReadLine()) != null)
            {
                i = 0;
                while (i < 3)
                {
                    aux = text.Substring(count, 1);
                    Console.WriteLine(aux);
                    if (i == 0)
                    {
                        if ((aux == "1") || (aux == "2") || (aux == "3") || (aux == "4") || (aux == "5") || (aux == "6") || (aux == "7") || (aux == "8") || (aux == "9") || (aux == "0"))
                        {
                            l = Int32.Parse(aux);
                            count++;
                            Console.WriteLine("i=" + i);
                            aux = text.Substring(count, 1);
                        }
                    }

                    if (i == 1)
                    {
                        if ((aux == "1") || (aux == "2") || (aux == "3") || (aux == "4") || (aux == "5") || (aux == "6") || (aux == "7") || (aux == "8") || (aux == "9") || (aux == "0"))
                        {
                            w = Int32.Parse(aux);
                            count++;
                            Console.WriteLine("i=" + i);
                            aux = text.Substring(count, 1);
                        }
                    }

                    if (i == 2)
                    {
                        if ((aux == "1") || (aux == "2") || (aux == "3") || (aux == "4") || (aux == "5") || (aux == "6") || (aux == "7") || (aux == "8") || (aux == "9") || (aux == "0"))
                        {
                            h = Int32.Parse(aux);
                            count++;
                            Console.WriteLine("i=" + i);
                            aux = text.Substring(count, 1);
                        }
                    }

                    if ((aux == "") || (aux == " "))
                    {
                        i = 3;
                        Console.WriteLine(@"aux = ''");
                    }

                    if (i == 3)
                    {
                        count++;
                    }

                    if ((aux == "x") || (aux == "X"))
                    {
                        i++;
                        Console.WriteLine(aux);
                        count++;
                    }
                    Console.ReadKey();
                }
                soma += (2 * l * w + 2 * w * h + 2 * h * l) + l * w;
            }

            Console.WriteLine("Square feet of wrapping paper needed:" + soma);
            Console.ReadKey();

        }
    }
}
