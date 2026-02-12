using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260212_beakjoon_34760
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            string[] input = sr.ReadLine().Split(' ');
            int[] noses = new int[input.Length];
            int bigest = 0;
            int count = 0;
            int index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                noses[i] = int.Parse(input[i]);
                if (bigest < noses[i])
                {
                    bigest = noses[i];
                    count = 0;
                    index = i;
                }
                else if(bigest == noses[i])
                {
                    count++;
                }
            }

            
            if(index == input.Length-1 && count == 0)
            {
                Console.WriteLine($"{bigest}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{bigest + 1}");
                Console.ReadLine();
            }

            
        }
    }
}
