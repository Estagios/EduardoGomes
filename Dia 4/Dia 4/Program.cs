using System.Linq;
using System;
using System.Security.Cryptography;
using System.Text;


namespace MD5Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "ckczppom";
            int answer = 0;
            int i = 0;
            using (MD5 md5Hash = MD5.Create())
            {
                var hash = string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(text)).Select(s => s.ToString("x2")));

                while (hash.Substring(0, +6) != "000000")
                {
                    if (i == 0)
                    {   
                        if (hash.Substring(0, +5) == "00000")
                        {
                            i++;
                            Console.WriteLine("Esta é a " + i + "ª chave para o hash com 5 zeros: " + hash + " : " + answer);
                            Console.WriteLine("Pressione qualquer tecla avançar.");
                            Console.WriteLine();
                            Console.ReadKey();
                        }
                    }
                    answer++;
                    hash = string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(text+answer)).Select(s => s.ToString("x2")));
                }
                Console.WriteLine("Esta é chave para o hash com 6 zeros: " + hash + " : " + answer);
                Console.WriteLine("Pressione qualquer tecla terminar o programa.");
                Console.ReadKey();
            }
        }      
    }
}