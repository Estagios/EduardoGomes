using System;
using System.IO;
using System.Linq;

namespace Dia_6
{
    internal class Program
    {
        public struct Begin
        {
            public bool x, y;
        }

        public struct End
        {
            public bool ex, ey;
        }

        public static void Main(string[] args)
        {
            var text = File.ReadAllLines("Dia 6 - Test1.txt");
            //var text = File.ReadAllLines(@"Dia 6.txt");
            MM(text);
            return;
        }

        private static void MM(string[] text)
        {
            int count = 0;
            int[,] lights = new int[1000, 1000];

            foreach (var line in text)
            {
                string[] words = line.Split(' ');
                if (words.Contains("toggle"))
                {
                    int exaux, eyaux, xaux, yaux;
                    NewMethod(words, out exaux, out eyaux, out xaux, out yaux);
                    for (int i = xaux; i < exaux; i++)
                    {
                        for (int j = yaux; j < eyaux; j++)
                        {
                            if (lights[i, j] == 1)
                                lights[i, j] = 0;
                            else if (lights[i, j] == 0)
                                lights[i, j] = 1;
                        }
                    }
                }

                if (words.Contains("turn off"))
                {
                    var aux = words[2].Split(',');
                    string[] eaux = words[4].Split(',');
                    var exaux = Int32.Parse(eaux[0]);
                    var eyaux = Int32.Parse(eaux[1]);
                    var xaux = Int32.Parse(aux[0]);
                    var yaux = Int32.Parse(aux[1]);
                    for (int i = xaux; i < exaux; i++)
                    {
                        for (int j = yaux; j < eyaux; j++)
                            lights[i, j] = 0;
                    }
                }
                if (words.Contains("on"))
                {
                    var aux = words[2].Split(',');
                    string[] eaux = words[4].Split(',');
                    var exaux = Int32.Parse(eaux[0]);
                    var eyaux = Int32.Parse(eaux[1]);
                    var xaux = Int32.Parse(aux[0]);
                    var yaux = Int32.Parse(aux[1]);
                    for (int i = xaux; i < exaux; i++)
                    {
                        for (int j = yaux; j < eyaux; j++)
                            lights[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                    if (lights[i, j] == 1)
                        count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }

        private static void NewMethod(string[] words, out int exaux, out int eyaux, out int xaux, out int yaux)
        {
            var aux = words[1].Split(',');
            var eaux = words[3].Split(',');
            exaux = Int32.Parse(eaux[0]);
            eyaux = Int32.Parse(eaux[1]);
            xaux = Int32.Parse(aux[0]);
            yaux = Int32.Parse(aux[1]);
        }
    }
}