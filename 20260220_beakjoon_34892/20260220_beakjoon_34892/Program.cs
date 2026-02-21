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

            string[] input = sr.ReadLine().Split(' ');

            long n = long.Parse(input[0]);
            long a = long.Parse(input[1]);
            long b = long.Parse(input[2]);
            long c = long.Parse(input[3]);
            long d = long.Parse(input[4]);
            long e = long.Parse(input[5]);
            long f = long.Parse(input[6]);
            long g = long.Parse(input[7]);
            long h = long.Parse(input[8]);

            if ((a - c) * (f - g) == (b - c) * (e - g))
            {
                if ((b - c) * (h - g * n) == (f - g) * (d - c * n) && (a - c) * (h - g * n) == (e - g) * (d - c * n))
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("2");
                }
            }
            else
            {
                if ((((f - g) * (d - c * n)) - ((h - g * n) * (b - c))) % (((a - c) * (f - g)) - ((b - c) * (e - g))) == 0 &&
                    (((a - c) * (h - g * n)) - ((e - g) * (d - c * n))) % (((a - c) * (f - g)) - ((b - c) * (e - g))) == 0)
                {
                    long x = (((f - g) * (d - c * n)) - ((h - g * n) * (b - c))) / (((a - c) * (f - g)) - ((b - c) * (e - g)));
                    long y = (((a - c) * (h - g * n)) - ((e - g) * (d - c * n))) / (((a - c) * (f - g)) - ((b - c) * (e - g)));
                    long z = n - x - y;

                    if (x >= 0 && y >= 0 && z >= 0)
                    {
                        Console.WriteLine("0");
                        Console.WriteLine($"{x} {y} {z}");
                    }
                    else
                    {
                        Console.WriteLine("2");
                    }
                }
                else
                {
                    Console.WriteLine("2");
                }
            }
            Console.ReadLine();
            //반례 4 1 2 10 23 2 4 20 46
            //기울기가 같은데 범위 안의 정수인 해는 1,1,2 하나라서
        }
    }
}
