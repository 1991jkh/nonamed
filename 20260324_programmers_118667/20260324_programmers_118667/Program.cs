using System;
using System.Collections.Generic;

namespace _20260324_programmers_118667
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int solution(int[] queue1, int[] queue2)
        {
            int answer = -2;
            int count = 0;

            long total;
            long sum1 = 0;
            long sum2 = 0;
            int largeNumb = 0;

            for (int i = 0; i < queue1.Length; i++)
            {
                sum1 += queue1[i];
                sum2 += queue2[i];
                if (largeNumb < queue1[i]) largeNumb = queue1[i];
                if (largeNumb < queue2[i]) largeNumb = queue2[i];
            }

            total = sum1 + sum2;

            Queue<int> Queue1 = new Queue<int>();
            Queue<int> Queue2 = new Queue<int>();

            if (total % 2 != 0 || total / 2 < largeNumb) answer = -1;
            else
            {
                for (int i = 0; i < queue1.Length; i++)
                {
                    Queue1.Enqueue(queue1[i]);
                    Queue2.Enqueue(queue2[i]);
                }

                while (sum1 != sum2)
                {
                    if (sum1 > sum2)
                    {
                        int temp = Queue1.Dequeue();
                        sum1 -= temp;
                        Queue2.Enqueue(temp);
                        sum2 += temp;
                        count++;
                    }
                    else if(sum2 > sum1)
                    {
                        int temp = Queue2.Dequeue();
                        sum2 -= temp;
                        Queue1.Enqueue(temp);
                        sum1 += temp;
                        count++;
                    }
                    if (count > queue1.Length * 4)
                    {
                        count = -1;
                        break;
                    }
                }

                answer = count;
            }

            return answer;
        }
    }
}
