using System;
using System.Collections.Generic;

namespace _20260320_programmers_77484
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Solution
    {
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[2];

            int zeroCount = 0;
            int correntCount = 0;

            for (int i = 0; i < lottos.Length; i++)
            {
                if (lottos[i] == 0) zeroCount++;
            }

            for (int i = 0; i < lottos.Length; i++)
            {
                for (int j = 0; j < win_nums.Length; j++)
                {
                    if (lottos[i] == win_nums[j]) correntCount++;
                }
            }

            int maxCorrect = correntCount + zeroCount;
            int grade = 0;

            if (correntCount == 6) grade = 1;
            if (correntCount == 5) grade = 2;
            if (correntCount == 4) grade = 3;
            if (correntCount == 3) grade = 4;
            if (correntCount == 2) grade = 5;
            if (correntCount == 1) grade = 6;
            if (correntCount == 0) grade = 6;

            if(maxCorrect == 6)
            {
                answer[0] = 1;
                answer[1] = grade;
            }
            if(maxCorrect == 5)
            {
                answer[0] = 2;
                answer[1] = grade;
            }
            if(maxCorrect == 4)
            {
                answer[0] = 3;
                answer[1] = grade;
            }
            if(maxCorrect == 3)
            {
                answer[0] = 4;
                answer[1] = grade;
            }
            if(maxCorrect == 2)
            {
                answer[0] = 5;
                answer[1] = grade;
            }
            if(maxCorrect == 1)
            {
                answer[0] = 6;
                answer[1] = grade;
            }
            if(maxCorrect == 0)
            {
                answer[0] = 6;
                answer[1] = grade;
            }

            return answer;
        }
    }

}
