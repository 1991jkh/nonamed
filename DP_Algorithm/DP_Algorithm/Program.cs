using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Algorithm
{
    class Program
    {
        static int[] dp_low = new int[50];

        static int[] dp_high = new int[50];
        static int lastIndex = 1;

        public static int Top_Down(int n)
        {
            if (n <= 1) return dp_low[n];
            if (dp_low[n] != 0) return dp_low[n];

            dp_low[n] = Top_Down(n - 1) + Top_Down(n - 2);

            return dp_low[n];
        }

        public static int Bottom_Up(int n)
        {
            if (n < lastIndex) return dp_high[n];

            for (int i = lastIndex + 1; i <= n; i++)
            {
                dp_high[i] = dp_high[i - 1] + dp_high[i - 2];
            }
            lastIndex = n;

            return dp_high[n];
        }



        static void Main(string[] args)
        {
            dp_low[0] = 0;
            dp_low[1] = 1;

            dp_high[0] = 0;
            dp_high[1] = 1;

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Top_Down(input));
            Console.WriteLine(Bottom_Up(input));
        }
    }
}
