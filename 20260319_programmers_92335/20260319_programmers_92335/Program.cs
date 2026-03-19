using System;
using System.Collections.Generic;

namespace _20260319_programmers_92335
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(solution(n, k));
            Console.ReadLine();
        }


        static int solution(int n, int k)
        {
            int answer = 0;

            List<int> remains = new List<int>();
            int remain;
            int quotient = n;
            while (quotient > k)
            {
                remain = quotient % k;
                quotient /= k;
                remains.Add(remain);
            }
            remains.Add(quotient);

            for (int i = 0; i < remains.Count; i++)
            {
                Console.WriteLine(remains[i]);

            }


            int checkdecimal = 0;
            int digits = 0;
            int count = 0;
            bool isDecimal = true;

            for (int i = 0; i < remains.Count; i++)
            {
                isDecimal = true;
                checkdecimal += remains[i] * (int)Math.Pow(k, digits);
                int temp = remains[i];
                digits++;
                if (remains[i] == 0)
                {
                    if (checkdecimal == 1)
                    {
                        checkdecimal = 0;
                        digits = 0;
                        continue;
                    }
                    count = 0;
                    for (int j = 2; j < checkdecimal; j++)
                    {
                        if (checkdecimal % j == 0)
                        {
                            count++;
                        }
                        if (count > 2)
                        {
                            isDecimal = false;
                            break;
                        }
                    }
                    checkdecimal = 0;
                    digits = 0;
                    if (isDecimal) answer++;
                    continue;
                }
            }
            count = 0;
            isDecimal = true;
            for (int j = 2; j < checkdecimal; j++)
            {
                if (checkdecimal % j == 0)
                {
                    count++;
                }
                if (count > 2)
                {
                    isDecimal = false;
                    break;
                }
            }
            if (isDecimal) answer++;

            return answer;
        }
    }
}
