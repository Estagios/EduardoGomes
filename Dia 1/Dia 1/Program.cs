using System;

namespace Dia_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            int soma = 0;

            string text = System.IO.File.ReadAllText(@"C:\Users\jose gomes\Desktop\Pasta de segurança da PEN do Edu, ou apenas coisinhas da 'escolinha'\Estágio (FCT)\Projeto\Dia 1\Dia 1\bin\Debug\Dia 1.txt");
            
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
