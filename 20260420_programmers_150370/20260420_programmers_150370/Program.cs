using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20260420_programmers_150370
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public int[] solution(string today, string[] terms, string[] privacies)
        {
            List<int> result = new List<int>();

            string[] YMD = today.Split('.');

            int todayY = int.Parse(YMD[0]);
            int todayM = int.Parse(YMD[1]);
            int todayD = int.Parse(YMD[2]);

            string[] expireDiv = new string[terms.Length];
            int[] expireMon = new int[terms.Length];

            for (int i = 0; i < terms.Length; i++)
            {
                string[] temp = terms[i].Split(' ');
                expireDiv[i] = temp[0];
                expireMon[i] = int.Parse(temp[1]);
            }

            int expireCount = 0;

            string privacyDiv = "";
            int privacyY = 0;
            int privacyM = 0;
            int privacyD = 0;

            for (int i = 0; i < privacies.Length; i++)
            {
                string[] tempDiv = privacies[i].Split(' ');
                privacyDiv = tempDiv[1];

                string[] tempYMD = tempDiv[0].Split('.');
                privacyY = int.Parse(tempYMD[0]);
                privacyM = int.Parse(tempYMD[1]);
                privacyD = int.Parse(tempYMD[2]);


            }

            



            int[] answer = new int[] { };
            return answer;
        }
    }
}
