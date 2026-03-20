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
            while (quotient >= k)
            {
                remain = quotient % k;
                quotient /= k;
                remains.Add(remain);
            }
            remains.Add(quotient);

            double checkdecimal = 0;
            int digits = 0;

            bool isDecimal;

            for (int i = 0; i < remains.Count; i++)
            {
                isDecimal = true;
                checkdecimal += remains[i] * Math.Pow(10, digits);
                digits++;
                if (remains[i] == 0)
                {
                    if (checkdecimal == 1 || checkdecimal == 0)
                    {
                        checkdecimal = 0;
                        digits = 0;
                        isDecimal = false;
                        continue;
                    }
                    else
                    {
                        for (long j = 2; j*j <= checkdecimal; j++)
                        {
                            if (checkdecimal % j == 0)
                            {
                                checkdecimal = 0;
                                digits = 0;
                                isDecimal = false;
                                break;
                            }
                        }
                        checkdecimal = 0;
                        digits = 0;
                        if (isDecimal) answer++;
                    }
                }
            }

            isDecimal = true;

            if (checkdecimal == 1 || checkdecimal == 0)
            {
                checkdecimal = 0;
                digits = 0;
                isDecimal = false;
            }

            for (long j = 2; j*j <= checkdecimal; j++)
            {
                if (checkdecimal % j == 0)
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
