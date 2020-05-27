using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Dia_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "ckczppom";
            int answer = 0;
            string total = "";
            
            using (MD5 md5Hash = MD5.Create())
            {
                string hash = GetMd5Hash(md5Hash, source);
                while (hash.Substring(0, +5) != "00000")
                {
                    answer += 1;
                }
            }
    }
}
