using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260219_beakjoon_1443
{
    class Program
    {
        static void Main(string[] args)
        {
            //2~9 사이 숫자를 P번 곱해서 D 자릿수를 만듦 첫 줄에 D P 를 입력받음 2<=D<=8 , 0<=P<=30
            //그중 가장 큰 수를 출력
            //P번 연산 결과가 모두 자릿수를 넘으면 -1을 출력

            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            string[] input = sr.ReadLine().Split(' ');

            int digit = int.Parse(input[0]);
            int multiple = int.Parse(input[1]);

            int result = 1;
            int temp = 1;

            int numb = 2;

            int answer = 0;

            while (multiple >= 1)
            {
                for (int i = 0; i < multiple; i++)
                {
                    temp *= numb;
                }

                for(int i=0; i<9-multiple;i++)
                {
                    temp *= numb + 1;
                }

                if (Math.Log10(temp) - 1 >= digit && numb ==2)
                {
                    answer = -1;
                }
                else
                {
                    if (temp > result)
                    {
                        result = temp;
                    }
                }
            }

            Console.WriteLine($"{answer}");
            Console.ReadLine();
        }
    }
}
