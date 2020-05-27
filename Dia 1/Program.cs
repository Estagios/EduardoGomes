using System;
using System.Linq;

namespace Dia_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            int soma = 0;

            string text = System.IO.File.ReadAllText(@"Dia 1.txt");
            Console.WriteLine(text.Count(x => x == '(') - text.Count(x => x == ')'));
            var lista = text.Where(x => x == '(');
            foreach (var item in lista)
            {
                Console.Write(item);
            }
            Console.WriteLine(text.Where(x => x == '(').Count());


            if (text != "")
            {
                while (i != text.Length)
                {
                    var cop = text.Substring(i, + 1);
                    
                    i++;
                    if (cop == "(")
                    {
                        soma += 1;
                    }
                    if (cop == ")")
                    {
                        soma -= 1;
                    }
                    if (soma == -1)
                    {
                        Console.WriteLine(i);
                    }

                }
                Console.WriteLine(soma);
            }
            Console.ReadKey();
        }
    }
}
