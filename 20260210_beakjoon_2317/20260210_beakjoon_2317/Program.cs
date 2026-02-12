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

            long sum = 0;
            long result = 0;

            for (int i = 1; i < lions.Count; i++)
            {
                sum += Math.Abs(lions[i] - lions[i - 1]);
            }


            if (normals.Count > 1)
            {
                int gap_first = Math.Abs(normals[0] - lions[0]);
                int index_first = 0;
                if (gap_first > Math.Abs(normals[0] - lions[lions.Count - 1]))
                {
                    gap_first = Math.Abs(normals[0] - lions[lions.Count - 1]);
                    index_first = lions.Count - 1;
                }
                for (int j = 1; j < lions.Count; j++)
                {
                    int temp = Math.Abs(normals[0] - lions[j]) + Math.Abs(normals[0] - lions[j - 1]) - Math.Abs(lions[j] - lions[j - 1]);
                    if (temp < gap_first)
                    {
                        gap_first = temp;
                        index_first = j;
                    }
                }

                int gap_last = Math.Abs(normals[normals.Count - 1] - lions[0]);
                int index_last = 0;
                if (gap_last > Math.Abs(normals[normals.Count - 1] - lions[lions.Count - 1]))
                {
                    gap_last = Math.Abs(normals[normals.Count - 1] - lions[lions.Count - 1]);
                    index_last = lions.Count - 1;
                }
                for (int j = 1; j < lions.Count; j++)
                {
                    int temp = Math.Abs(normals[normals.Count - 1] - lions[j]) + Math.Abs(normals[normals.Count - 1] - lions[j - 1]) - Math.Abs(lions[j] - lions[j - 1]);
                    if (temp < gap_last)
                    {
                        gap_last = temp;
                        index_last = j;
                    }
                }

                //if (index_first == index_last && (index_first != 0 || index_first != lions.Count-1))
                //{
                //    result = gap_first + gap_last + sum;
                //}
                //if ((index_first == index_last) && ((index_first == 0) || (index_first == lions.Count - 1)))
                //{
                //    int gap = Math.Max(gap_first, gap_last);
                //    result = gap + sum;
                //}
                //else if ((index_first == index_last) && ((index_first != 0) || (index_first != lions.Count - 1)))
                //{
                //    int gap_small = Math.Min(gap_first, gap_last);
                //    if (gap_small == gap_first)
                //    {
                //        int gap = Math.Abs(lions[index_first] - normals[0]) + Math.Abs(normals[normals.Count - 1] - normals[0]) + Math.Abs(normals[normals.Count - 1] - lions[index_first]) + Math.Abs(lions[index_first] - lions[index_first - 1]);
                //        result = gap + sum;
                //    }
                //}
                //else
                //{
                //    result = gap_first + gap_last + sum;
                //}

                int lion_min = lions.Min();
                int lion_max = lions.Max();
                int gap = 0;
                if(normals[0] < lion_min)
                {
                    gap += gap_first;
                }
                if(normals[normals.Count-1] > lion_max)
                {
                    gap += gap_last;
                }
                result = gap + sum;
            }
            else if (normals.Count == 1)
            {
                int gap = Math.Abs(normals[0] - lions[0]);
                if (gap > Math.Abs(normals[0] - lions[lions.Count - 1]))
                {
                    gap = Math.Abs(normals[0] - lions[lions.Count - 1]);
                }
                for (int j = 1; j < lions.Count; j++)
                {
                    int temp = Math.Abs(normals[0] - lions[j]) + Math.Abs(normals[0] - lions[j - 1]) - Math.Abs(lions[j] - lions[j - 1]);
                    if (temp < gap)
                    {
                        gap = temp;
                    }
                }
                result = gap + sum;
            }
            else
            {
                result = sum;
            }

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


