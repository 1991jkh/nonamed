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

            normals.Sort();

            for (int i = 0; i < lions.Count; i++)
            {
                int left = Math.Min(lions[i - 1], lions[i]);
                int right = Math.Max(lions[i - 1], lions[i]);
                for (int j = 0; i < normals.Count; j++)
                {
                    if (left < normals[j] && normals[j] < right)
                    {
                        normals.RemoveAt(i);
                    }
                }
            }




            int result = 0;

            for (int i = 1; i < lions.Count; i++)
            {
                result += Math.Abs(lions[i] - lions[i - 1]);
            }

            //result += Math.min 으로 normals에 남아있는 첫 수 와 마지막 수. lion 0, 마지막 이렇게 비교해서 result에 더하기
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