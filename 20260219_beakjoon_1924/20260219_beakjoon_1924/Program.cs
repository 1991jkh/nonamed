using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260219_beakjoon_1924
{
    class Program
    {
        static void Main(string[] args)
        {

            //1월 1일 월요일
            //x y 입력 x : 월 y : 일
            //그 날의 요일 출력
            //1,3,5,7,8,10,12 는 31일까지
            //4,6,9,11 은 30일까지
            //2월은 28일까지

            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            string[] input = sr.ReadLine().Split(' ');

            int month = int.Parse(input[0]);
            int day = int.Parse(input[1]);

            int dayCount = 0;

            int[,] fullDay = new int[12, 1];

            fullDay[0, 0] = 31;
            fullDay[1, 0] = 28;
            fullDay[2, 0] = 31;
            fullDay[3, 0] = 30;
            fullDay[4, 0] = 31;
            fullDay[5, 0] = 30;
            fullDay[6, 0] = 31;
            fullDay[7, 0] = 31;
            fullDay[8, 0] = 30;
            fullDay[9, 0] = 31;
            fullDay[10, 0] = 30;
            fullDay[11, 0] = 31;

            for (int i = 0; i < month-1; i++)
            {
                dayCount += fullDay[i, 0];
            }

            dayCount += day;

            int result = 0;

            result = dayCount % 7;


            if (result == 1)
            {
                Console.WriteLine("MON");
            }
            else if (result == 2)
            {
                Console.WriteLine("TUE");
            }
            else if (result == 3)
            {
                Console.WriteLine("WED");
            }
            else if (result == 4)
            {
                Console.WriteLine("THU");
            }
            else if (result == 5)
            {
                Console.WriteLine("FRI");
            }
            else if (result == 6)
            {
                Console.WriteLine("SAT");
            }
            else if (result == 0)
            {
                Console.WriteLine("SUN");
            }
            Console.ReadLine();
        }
    }
}
