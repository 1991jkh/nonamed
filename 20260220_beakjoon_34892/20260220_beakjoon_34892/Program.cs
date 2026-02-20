using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260220_beakjoon_34892
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            string[] input = sr.ReadLine().Split(' ');

            int n = int.Parse(input[0]);
            int a = int.Parse(input[1]);
            int b = int.Parse(input[2]);
            int c = int.Parse(input[3]);
            int d = int.Parse(input[4]);
            int e = int.Parse(input[5]);
            int f = int.Parse(input[6]);
            int g = int.Parse(input[7]);
            int h = int.Parse(input[8]);

            if(((a-c)/(e-g) == (b-c)/(f-g)) && ((b-c)/(f-g) != (d-c*n)/(h-g*n)))
            {
                Console.WriteLine("2");
            }
            else if(((a-c)/(e-g) == (b-c)/(f-g)) && ((b-c)/(f-g) == (d-c*n)/(h-g*n)))
            {
                Console.WriteLine("1");
            }
            else
            {
                int x = (((h - g*n) * (b - c)) - ((f - g) * (d - c*n))) / (((e - g) * (b - c)) - ((f - g) * (a - c)));
                int y = (((d - c*n) - (a - c)) * x) / (b - c);
                int z = n-x-y;

                Console.WriteLine("0");
                Console.WriteLine($"{x} {y} {z}");
            }
            Console.ReadLine();
        }
    }
}
