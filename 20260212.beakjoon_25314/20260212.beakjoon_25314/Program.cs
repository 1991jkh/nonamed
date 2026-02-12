using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260212.beakjoon_25314
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int byteAmount = int.Parse(sr.ReadLine());

            int longCount = byteAmount / 4;


            for(int i=0;i<longCount;i++)
            {
                sb.Append("long ");
            }
            sb.Append("int");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
