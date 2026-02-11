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

            for (int i = 1; i < lions.Count; i++)
            {
                int left = Math.Min(lions[i - 1], lions[i]);
                int right = Math.Max(lions[i - 1], lions[i]);
                for (int j = normals.Count - 1; j >= 0; j--)
                {
                    if (left < normals[j] && normals[j] < right)
                    {
                        normals.RemoveAt(j);
                    }
                }
            }

            int result = 0;

            for (int i = 1; i < lions.Count; i++)
            {
                result += Math.Abs(lions[i] - lions[i - 1]);
            }


            if (normals.Count != 0)
            {
                for (int i = 0; i < normals.Count; i++)
                {
                    int gap = 0;
                    for (int j = 0; j < lions.Count - 1; j++)
                    {
                        int temp = Math.Abs(normals[i] - lions[j]) + Math.Abs(normals[i] - lions[j + 1]) - Math.Abs(lions[j] - lions[j + 1]);
                        if (temp < gap) gap = temp;
                    }
                }
            }



            //int lion_min = Math.Min(lions[0], lions[lions.Count - 1]);
            //int lion_max = Math.Max(lions[0], lions[lions.Count - 1]);

            //if (normals.Count > 0)
            //{
            //    if (normals[0] < lion_min)
            //    {
            //        result += Math.Abs(normals[0] - lion_min);
            //    }

            //    if (normals[normals.Count - 1] > lion_max)
            //    {
            //        result += Math.Abs(normals[normals.Count - 1] - lion_max);
            //    }

            //normals[0]
            //normals[normals.Count-1]
            //int min_left = Math.Min()



            //result += Math.min 으로 normals에 남아있는 첫 수 와 마지막 수. lion 0, 마지막 이렇게 비교해서 result에 더하기
            //Console.WriteLine();
            Console.WriteLine($"{result}");
            sr.ReadLine();
            //for (int i = 0; i < lions.Count; i++)
            //{
            //    Console.WriteLine($"{lions[i]}");
            //}
        }
    }
}
