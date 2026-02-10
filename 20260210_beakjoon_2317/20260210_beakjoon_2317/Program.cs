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
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader(Console.OpenStandardOutput());

            string[] input = sr.ReadLine().Split(' ');

            int lionAmount = int.Parse(input[1]);
            int[] Lions = new int[lionAmount];

            int totalAmount = int.Parse(input[0]);
            int[] normals = new int[totalAmount-lionAmount];

            for (int i = 0; i < Lions.Length; i++)
            {
                Lions[i] = int.Parse(sr.ReadLine());
            }
            for (int i = 0; i < normals.Length; i++)
            {
                normals[i] = int.Parse(sr.ReadLine());
            }

            List<int> instance = new List<int>();
            List<int> count = new List<int>();
            int numbAcount = 0;

            for(int a=1; a<Lions.Length; a++)
            {
                if(Lions[a] > Lions[a-1])
                {
                    for (int i = 0; i < normals.Length; i++)//작은수 먼저
                    {
                        for (int j = 1; j < normals.Length; j++)
                        {
                            if (normals[i] > normals[j])
                            {
                                int temp = normals[j];
                                normals[j] = normals[i];
                                normals[i] = temp;
                            }
                        }
                    }

                    for (int n = 1; n < Lions.Length; n++)
                    {
                        for (int m = 0; m < normals.Length; m++)
                        {
                            if ((normals[m] > Lions[n] && normals[m] < Lions[n - 1]) || (normals[m] < Lions[n] && normals[m] > Lions[n - 1]))
                            {
                                numbAcount++;
                                instance.Add(normals[n]);
                            }
                        }
                        count.Add(numbAcount);
                        numbAcount = 0;
                    }
                }
                if (Lions[a] < Lions[a-1])
                {
                    for (int i = 0; i < normals.Length; i++)//큰수 먼저
                    {
                        for (int j = 1; j < normals.Length; j++)
                        {
                            if (normals[i] < normals[j])
                            {
                                int temp = normals[j];
                                normals[j] = normals[i];
                                normals[i] = temp;
                            }
                        }
                    }

                    for (int n = 1; n < Lions.Length; n++)
                    {
                        for (int m = 0; m < normals.Length; m++)
                        {
                            if ((normals[m] > Lions[n] && normals[m] < Lions[n - 1]) || (normals[m] < Lions[n] && normals[m] > Lions[n - 1]))
                            {
                                numbAcount++;
                                instance.Add(normals[n]);
                            }
                        }
                        count.Add(numbAcount);
                        numbAcount = 0;
                    }
                }
            }

            List<int> total = new List<int>();
            int Q = 0;
            for(int i=0; i<Lions.Length; i++)
            {
                total.Add(Lions[i]);
                for(Q=0; Q<count[i]; Q++)
                {
                    total.Add(instance[Q]);
                }
                instance.RemoveRange(0,count[i]);
            }

            List<int> small = new List<int>();
            int smallCount = 0;
            List<int> large = new List<int>();
            int largetCount = 0;
            List<int> final = new List<int>();
            for(int a=0;a<normals.Length; a++)
            {
                if(Lions[a]<Lions[lionAmount])
                {
                    for (int i = 0; i < normals.Length; i++)//작은수 먼저
                    {
                        for (int j = 1; j < normals.Length; j++)
                        {
                            if (normals[i] > normals[j])
                            {
                                int temp = normals[j];
                                normals[j] = normals[i];
                                normals[i] = temp;
                            }
                        }
                    }


                }
            }

            int result = 0;

            for (int i = 1; i < total.Count; i++)
            {
                result += Math.Abs(total[i] - total[i - 1]);
            }

            Console.WriteLine($"{result}");
            sr.Read();
        }
    }
}
#region 1
//for (int i = 0; i < normals.Length; i++)//큰수 먼저
//{
//    for (int j = 1; j < normals.Length; j++)
//    {
//        if (normals[i] < normals[j])
//        {
//            int temp = normals[j];
//            normals[j] = normals[i];
//            normals[i] = temp;
//        }
//    }
//}

//for (int i = 0; i < normals.Length; i++)//작은수 먼저
//{
//    for (int j = 1; j < normals.Length; j++)
//    {
//        if (normals[i] > normals[j])
//        {
//            int temp = normals[j];
//            normals[j] = normals[i];
//            normals[i] = temp;
//        }
//    }
//}

//for (int n = 1; n < Lions.Length; n++)
//{
//    for (int m = 0; m < normals.Length; m++)
//    {
//        if ((normals[m] > Lions[n] && normals[m] < Lions[n - 1]) || (normals[m] < Lions[n] && normals[m] > Lions[n - 1]))
//        {
//            numbAcount++;
//            instance.Add(normals[n]);
//        }
//    }
//    count.Add(numbAcount);
//    numbAcount = 0;
//}
#endregion

