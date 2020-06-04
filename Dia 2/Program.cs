using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace prisma_presente
{
    class Program
    {
        struct Prisma
        {
            public int c, l, a;
        }

        static int Calc_area(Prisma prisma)
        {
            // Array com a area de cada lado
            int[] lado = new int[3] { (prisma.c * prisma.l), (prisma.c * prisma.a), (prisma.l * prisma.a) };

            // Menor lado (o valor inicial é o primeiro lado do array)
            int menor_lado = lado[0];

            // Variavel para a soma do dobro de cada lado do prisma
            int area_calc = 0;

            // Começa a procurar o menor lado
            for (int j = 0; j < lado.Length; j++)
            {
                // Caso o lado atual for menor atribui o valor da area à variavel menor_lado
                if (lado[j] < menor_lado)
                {
                    menor_lado = lado[j];
                }

                // Calculo da area
                area_calc += 2 * lado[j];
            }

            // Adição da area menor
            area_calc += menor_lado;

            // retorna a area
            return area_calc;
        }

        static int Calc_fita(Prisma prisma)
        {
            int wid_fita;

            if (prisma.c > prisma.l && prisma.c > prisma.a)
            {
                wid_fita = 2 * prisma.l + 2 * prisma.a;
            }
            else if (prisma.l > prisma.c && prisma.l > prisma.a)
            {
                wid_fita = 2 * prisma.c + 2 * prisma.a;
            }
            else
            {
                wid_fita = 2 * prisma.c + 2 * prisma.l;
            }

            wid_fita += prisma.c * prisma.l * prisma.a;
            return wid_fita;
        }

        static void Main(string[] args)
        {
            // Array do registo Prisma
            Prisma[] pr = new Prisma[0];
            int n = 0;

            int[] temp; // Retirar as 3 dimencoes do prisma (para depois colocar no array pr)

            // StreamReader para abrir e ler o ficheiro
            var text = File.ReadAllLines(@"Dia 2.txt");

            // Percorre todo o ficheiro
            foreach (var line in text)
            {
                // Obtem o array de inteiros com as 3 dimencoes do prisma
                temp = Array.ConvertAll(line.Split('x'), int.Parse);

                // Redimenciona o array pr e guarda as dimencoes na ultima posição
                n++;
                Array.Resize(ref pr, n);
                pr[n - 1].c = temp[0];
                pr[n - 1].l = temp[1];
                pr[n - 1].a = temp[2];
            }

            // Variável para o calculo da area de cada prisma 
            // e variavel para o calculo da soma das areas
            int area, soma, soma_fita;
            soma_fita = 0;
            soma = 0;

            // Pecorre todas as opçoes de prismas para calcular a soma das areas totais de todos
            for (int i = 0; i < pr.Length; i++)
            {
                // Calcula a area do prisma atual
                area = Calc_area(pr[i]);

                soma_fita += Calc_fita(pr[i]);
                Console.WriteLine($"Fita necessária para este prisma ({pr[i].c}x{pr[i].l}x{pr[i].a}): {Calc_fita(pr[i])}\nsoma até agr: {soma_fita}\n");

                // Calcula a soma das areas
                soma += area;
            }

            // Apresenta informacoes relevantes (valor da soma/média da area gasta p/presente)
            Console.WriteLine($"\nA área total de papel que se precisa encomendar é {soma}\nÉ necessário {soma_fita} de fita no total");
            Console.ReadKey();
        }
    }
}

