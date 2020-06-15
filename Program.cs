using System;
using System.IO;
using System.Linq;

namespace Dia_5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var text = File.ReadAllLines(@"Dia 5.txt");

            MM(text);
            //MM2(text);
            return;

        }

        private static void MM(string[] text)
        {
            int count = 0;

            foreach (var line in text)
            {
                Console.WriteLine(line);
                bool firstCond = CalcFirstCond(line);
                var thirdCond = !line.Contains("ab") && !line.Contains("cd") && !line.Contains("pq") && !line.Contains("xy");
                var secCond = false;
                for (int i = 0; i < line.Length - 1; i++)
                {
                    secCond = line[i] == line[i + 1];
                    if (secCond)
                        break;
                }

                if (firstCond && secCond && thirdCond)
                    count++;

                Console.WriteLine(firstCond);
                Console.WriteLine(secCond);
                Console.WriteLine(thirdCond);
            }

            Console.WriteLine(count);
        }

        /*private static void MM2(string[] text)
        {
            int count = 0;

            foreach (var line in text)
            {
                Console.WriteLine(line);
                bool firstCond = CalcFirstCond(line);
                var thirdCond = !line.Contains("ab") && !line.Contains("cd") && !line.Contains("pq") && !line.Contains("xy");
                var secCond = false;
                for (int i = 0; i < line.Length - 1; i++)
                {
                    secCond = line[i] == line[i + 1];
                    if (secCond)
                        break;
                }

                if (firstCond && secCond && thirdCond)
                    count++;

                Console.WriteLine(firstCond);
                Console.WriteLine(secCond);
                Console.WriteLine(thirdCond);
            }

            Console.WriteLine(count);
        }*/

        private static bool CalcFirstCond(string line)
        {
            return line.Count(p => p == 'a' || p == 'e' || p == 'i' || p == 'o' || p == 'u') >= 3;
        }
    }
}