using System;
using System.Collections.Generic;


namespace _20260326_programmers_118666
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public string solution(string[] survey, int[] choices)
        {
            int R = 0;
            int T = 0;

            int C = 0;
            int F = 0;

            int J = 0;
            int M = 0;

            int A = 0;
            int N = 0;

            for(int i=0;i<survey.Length;i++)
            {
                char[] splitSurvey = survey[i].ToCharArray();

                if(choices[i] == 1)
                {
                    if (splitSurvey[0] == 'R') R += 3;
                    if (splitSurvey[0] == 'T') T += 3;
                    if (splitSurvey[0] == 'C') C += 3;
                    if (splitSurvey[0] == 'F') F += 3;
                    if (splitSurvey[0] == 'J') J += 3;
                    if (splitSurvey[0] == 'M') M += 3;
                    if (splitSurvey[0] == 'A') A += 3;
                    if (splitSurvey[0] == 'N') N += 3;
                }
                if(choices[i] == 2)
                {
                    if (splitSurvey[0] == 'R') R += 2;
                    if (splitSurvey[0] == 'T') T += 2;
                    if (splitSurvey[0] == 'C') C += 2;
                    if (splitSurvey[0] == 'F') F += 2;
                    if (splitSurvey[0] == 'J') J += 2;
                    if (splitSurvey[0] == 'M') M += 2;
                    if (splitSurvey[0] == 'A') A += 2;
                    if (splitSurvey[0] == 'N') N += 2;
                }
                if (choices[i] == 3)
                {
                    if (splitSurvey[0] == 'R') R += 1;
                    if (splitSurvey[0] == 'T') T += 1;
                    if (splitSurvey[0] == 'C') C += 1;
                    if (splitSurvey[0] == 'F') F += 1;
                    if (splitSurvey[0] == 'J') J += 1;
                    if (splitSurvey[0] == 'M') M += 1;
                    if (splitSurvey[0] == 'A') A += 1;
                    if (splitSurvey[0] == 'N') N += 1;
                }
                if (choices[i] == 4)
                {
                    continue;
                }
                if(choices[i] == 5)
                {
                    if (splitSurvey[1] == 'R') R += 1;
                    if (splitSurvey[1] == 'T') T += 1;
                    if (splitSurvey[1] == 'C') C += 1;
                    if (splitSurvey[1] == 'F') F += 1;
                    if (splitSurvey[1] == 'J') J += 1;
                    if (splitSurvey[1] == 'M') M += 1;
                    if (splitSurvey[1] == 'A') A += 1;
                    if (splitSurvey[1] == 'N') N += 1;
                }
                if (choices[i] == 6)
                {
                    if (splitSurvey[1] == 'R') R += 2;
                    if (splitSurvey[1] == 'T') T += 2;
                    if (splitSurvey[1] == 'C') C += 2;
                    if (splitSurvey[1] == 'F') F += 2;
                    if (splitSurvey[1] == 'J') J += 2;
                    if (splitSurvey[1] == 'M') M += 2;
                    if (splitSurvey[1] == 'A') A += 2;
                    if (splitSurvey[1] == 'N') N += 2;
                }
                if (choices[i] == 7)
                {
                    if (splitSurvey[1] == 'R') R += 3;
                    if (splitSurvey[1] == 'T') T += 3;
                    if (splitSurvey[1] == 'C') C += 3;
                    if (splitSurvey[1] == 'F') F += 3;
                    if (splitSurvey[1] == 'J') J += 3;
                    if (splitSurvey[1] == 'M') M += 3;
                    if (splitSurvey[1] == 'A') A += 3;
                    if (splitSurvey[1] == 'N') N += 3;
                }
            }


            char[] result = new char[4];

            if (R >= T) result[0] = 'R';
            else result[0] = 'T';

            if (C >= F) result[1] = 'C';
            else result[1] = 'F';

            if (J >= M) result[2] = ('J');
            else result[2] = 'M';

            if (A >= N) result[3] = 'A';
            else result[3] = 'N';


            string answer = new string(result);

            return answer;
        }
    }
}
