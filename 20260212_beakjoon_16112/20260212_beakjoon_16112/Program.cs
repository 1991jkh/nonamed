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
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            string[] input = sr.ReadLine().Split(' ');
            string[] input_nd = sr.ReadLine().Split(' ');

            int acount = int.Parse(input[0]);
            int activeCount = int.Parse(input[1]);

            List<int> stone = new List<int>();

            for (int i = 0; i < acount; i++)
            {
                stone.Add(int.Parse(input_nd[i]));
            }

            stone.Sort();

            int result = 0;

            for(int i= stone.Count-1; activeCount>=0; i--)
            {
                result += stone[i] * activeCount;
                activeCount--;
            }

            Console.WriteLine($"{result}");
            Console.ReadLine();
        }
    }
}
