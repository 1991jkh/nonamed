using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260209_beakjoon_1003
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int inputAmount = int.Parse(sr.ReadLine());

            int[] numbers = new int[inputAmount];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(sr.ReadLine());
            }

            int[] count_0 = new int[50];
            int[] count_1 = new int[50];
            
            for (int i = 0; i < count_0.Length; i++)
            {
                fibonacci(i);
            
                int fibonacci(int n)
                {
                    if (n == 0)
                    {
                        count_0[n] = 1;
                    }
                    else if (n == 1)
                    {
                        count_0[n] = 0;
                    }
                    else
                    {
                        if (count_0[n] == 0)
                        {
                            count_0[n] = fibonacci(n - 1) + fibonacci(n - 2);
                        }
                    }
                    return count_0[n];
                }
            }
            for (int i = 0; i < count_1.Length; i++)
            {
                fibonacci(i);
            
                int fibonacci(int n)
                {
                    if (n == 0)
                    {
                        count_1[n] = 0;
                    }
                    else if (n == 1)
                    {
                        count_1[n] = 1;
                    }
                    else
                    {
                        if (count_1[n] == 0)
                        {
                            count_1[n] = fibonacci(n - 1) + fibonacci(n - 2);
                        }
                    }
                    return count_1[n];
                }
            }
            for(int i=0; i<numbers.Length; i++)
            {
                sb.AppendLine($"{count_0[numbers[i]]} {count_1[numbers[i]]}");
            }
            Console.Write(sb);
            sr.ReadLine();
            

            //int[,] count = new int[50, 2];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    fibonacci(numbers[i]);

            //    (int, int) fibonacci(int n)
            //    {
            //        if (n == 0)
            //        {
            //            return (count[n, 0] = 1, count[n, 1] = 0);
            //        }
            //        else if (n == 1)
            //        {
            //            return (count[n, 0] = 1, count[n, 1] = 0);
            //        }
            //        else
            //        {
            //            if (count[n, 0] == 0 && count[n, 1] == 0)
            //            {
            //                return (count[n, 0] = count[n - 1, 0] + count[n - 2, 0], count[n, 1] = count[n - 1, 1] + count[n - 2, 1]);
            //            }
            //        }
            //        return (count[n, 0], count[n, 1]);
            //    }
            //}
        }
    }
}
