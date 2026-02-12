using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260212_beakjoon_17952
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int amount = int.Parse(sr.ReadLine());

            Stack<int> grade = new Stack<int>();
            Stack<int> time = new Stack<int>();

            int result = 0;

            for (int i = 0; i < amount; i++)
            {
                string[] input = sr.ReadLine().Split(' ');
                int[] input_int = new int[3];

                if (input.Length == 3)
                {
                    for (int j = 0; j < input_int.Length; j++)
                    {
                        input_int[j] = int.Parse(input[j]);
                    }

                    input_int[2]--;

                    if (input_int[2] == 0) result += input_int[1];
                    else
                    {
                        grade.Push(input_int[1]);
                        time.Push(input_int[2]);
                    }
                }
                else
                {
                    if (time.Count > 0)
                    {
                        if (time.Peek() - 1 == 0)
                        {
                            time.Pop();
                            result += grade.Peek();
                            grade.Pop();
                        }
                        else
                        {
                            int temp = time.Peek();
                            time.Pop();
                            time.Push(temp - 1);
                        }
                    }
                }
            }
            Console.WriteLine($"{result}");
            Console.ReadLine();
        }
    }
}
