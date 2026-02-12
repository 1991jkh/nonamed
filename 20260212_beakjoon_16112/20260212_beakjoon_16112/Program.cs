using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260212_beakjoon_16112
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            string[] input = sr.ReadLine().Split(' ');
            string[] input_nd = sr.ReadLine().Split(' ');

            long acount = long.Parse(input[0]);
            long activeCount = long.Parse(input[1]);

            List<long> stone = new List<long>();

            for (int i = 0; i < acount; i++)
            {
                stone.Add(long.Parse(input_nd[i]));
            }

            stone.Sort();

            long result = 0;
            long count = 0;

            for(int i=0; i<stone.Count;i++)
            {
                result += stone[i] * count;
                if (count < activeCount) count++;
            }

            Console.WriteLine($"{result}");
            Console.ReadLine();
        }
    }
}
