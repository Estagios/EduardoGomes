using System;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        // Registo Point (x,y) - Para o Pai Natal        
        struct Point
        {
            public int x, y;
        }
        // Registo RPoint (rx,ry) - Para o Robot
        struct RPoint
        {
            public int rx, ry;
        }

        static void Main(string[] args)
        {

            var f = File.ReadAllText("Dia 3.txt");

            int i, x, y, rx, ry, soma;
            char ch;
            int n = 0;
            int r = 0;
            soma = 1;
            x = 0;
            y = 0;
            rx = 0;
            ry = 0;


            // Array e a variavel do tipo (R)Point
            RPoint rpoint;
            rpoint.rx = rx;
            rpoint.ry = ry;
            RPoint[] rarray = { rpoint };

            Point point;
            point.x = x;
            point.y = y;
            Point[] parray = { point };

            // circula por todos os caracteres da string da variavel f
            for (i = 0; i < f.Length; i++)
            {
                // retira o caracter referente à posicao i da string da variavel f
                ch = f.Substring(i, 1).ToCharArray()[0];
                if (i % 2 == 0)
                {
                    // atualiza a posicao (x, y) dependendo do caracter
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
                    // Guarda na variavel a posicao atual (x, y)
                    point.x = x;
                    point.y = y;

                    // verifica se a posicao atual (x, y) nao existe no array
                    if (Array.IndexOf(parray, point) == -1)
                    {
                        // o número de posicoes no array é incrementada, 
                        // o array é redimencionado e a posicao atual (x, y) é colocada no array
                        n++;
                        Array.Resize(ref parray, n);
                        parray[n - 1] = point;
                    }
                }

                if (i % 2 != 0)
                {

                    // atualiza a posicao (rx,  ry) dependendo do caracter
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
                    // Guarda na variavel a posicao atual (rx, ry)
                    rpoint.rx = rx;
                    rpoint.ry = ry;

                    // verifica se a posicao atual (rx, ry) nao existe no array
                    if (Array.IndexOf(rarray, rpoint) == -1)
                    {
                        // o número de posicoes no array é incrementada, 
                        // o array é redimencionado e a posicao atual (rx, ry) é colocada no array
                        r++;
                        Array.Resize(ref rarray, r);
                        rarray[r - 1] = rpoint;
                    }
                }
            }

            // mostra todas as posicoes por onde passou (conteudo do array parray e do rarray)
            i = -1;
            foreach (Point pointi in parray)
            {
                Console.WriteLine($"parray[{++i}]: x = {pointi.x}; y = {pointi.y}\n");
            }
            i = -1;
            foreach (RPoint rointi in rarray)
            {
                Console.WriteLine($"rarray[{++i}]: x = {rointi.rx}; y = {rointi.ry}\n");
            }

            Console.WriteLine($"\nNúmero de casas que receberam presentes do Pai Natal: {parray.Length}");
            Console.WriteLine($"\nNúmero de casas que receberam presentes do Robot Natal: {rarray.Length}");
            soma += parray.Length + rarray.Length;
            Console.WriteLine($"\nNúmero de casas que receberam presentes quer de um ou de outro: {soma}");

            Console.ReadKey();
        }
    }
}
