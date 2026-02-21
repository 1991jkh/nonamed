using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260222_beakjoon_34892_2
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

            int count = 0;

            long temp_x = 0;
            long temp_y = 0;
            long temp_z = 0;

            long x = 0;
            long y = 0;
            long z = 0;
            for (long i = 0; i <= n; i++)
            {
                for(long j=0;j<=n;j++)
                {
                    temp_x = i;
                    temp_y = j;
                    temp_z = n - temp_y - temp_x;
                    if(a* temp_x + b* temp_y + c* temp_z == d && e* temp_x + f* temp_y + g* temp_z == h)
                    {
                        count++;
                        x = temp_x;
                        y = temp_y;
                        z = temp_z;
                    }
                    if (count > 1) break;
                }
                if (count > 1) break;
            }
            if (count == 0)
            {
                Console.WriteLine("2");
            }
            else if (count == 1)
            {
                Console.WriteLine("0");
                Console.WriteLine($"{x} {y} {z}");
            }
            else
            {
                Console.WriteLine("1");
            }
            Console.ReadLine();
        }
    }
}
