using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260210_beakjoon_2317
{

    class Program
    {
        static List<int> bigtosmall(List<int> array)
        {
            for (int i = 0; i < array.Count; i++)//큰 작
            {
                for (int j = 1; j < array.Count; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }

            return array;
        }

        static List<int> smalltobig(List<int> array)
        {
            for (int i = 0; i < array.Count; i++)//작 큰
            {
                for (int j = 1; j < array.Count; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }

            return array;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            string[] input = sr.ReadLine().Split(' ');

            int totalAcount = int.Parse(input[0]);
            int lionAcount = int.Parse(input[1]);
            int normalAcount = totalAcount - lionAcount;

            List<int> lions = new List<int>();
            List<int> normals = new List<int>();

            for (int i = 0; i < lionAcount; i++)
            {
                lions.Add(int.Parse(sr.ReadLine()));
            }

            for (int i = 0; i < normalAcount; i++)
            {
                normals.Add(int.Parse(sr.ReadLine()));
            }

            for (int i = lions.Count - 1; i > 0; i--)
            {
                if (lions[i] < lions[i - 1])//큰 작
                {
                    bigtosmall(normals);
                    if (normals.Count != 0)
                    {
                        for (int j = normals.Count - 1; j >= 0; j--)
                        {
                            if (lions[i] < normals[j] && lions[i - 1] > normals[j])
                            {
                                lions.Insert(i, normals[j]);
                                normals.RemoveAt(j);
                            }
                        }
                    }
                }
                else if (lions[i] > lions[i - 1])//작 큰
                {
                    smalltobig(normals);
                    if (normals.Count != 0)
                    {
                        for (int j = normals.Count - 1; j >= 0; j--)
                        {
                            if (lions[i] > normals[j] && lions[i - 1] < normals[j])
                            {
                                lions.Insert(i, normals[j]);
                                normals.RemoveAt(j);
                            }
                        }
                    }
                }
            }

            int temp = 0;
            int index = 0;
            int result = 1000000000;

            if (normals.Count != 0)
            {
                for (int i = normals.Count - 1; i >= 0; i--)
                {
                    index = 0;
                    for (int j = lions.Count - 1; j >= 0; j--)
                    {
                        temp = 0;
                        lions.Insert(j + 1, normals[i]);
                        for (int k = lions.Count - 1; k > 0; k--)
                        {
                            temp += Math.Abs(lions[k] - lions[k - 1]);
                        }
                        if (result > temp)
                        {
                            result = temp;
                            index = j + 1;
                        }
                        lions.RemoveAt(j + 1);
                    }
                    lions.Insert(index, normals[i]);
                    normals.RemoveAt(i);
                }
            }
            else
            {
                result = 0;
                for (int i = 1; i < lions.Count; i++)
                {
                    result += Math.Abs(lions[i] - lions[i - 1]);
                }
            }
            //Console.WriteLine();
            Console.WriteLine($"{result}");
            //Console.WriteLine();
            //for (int i = 0; i < lions.Count; i++)
            //{
            //    Console.WriteLine($"{lions[i]}");
            //}
            Console.ReadLine();
        }
    }
}