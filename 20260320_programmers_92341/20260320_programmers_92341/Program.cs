using System;
using System.Collections.Generic;

namespace _20260320_programmers_92341
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public List<int> solution(int[] fees, string[] records)
        {
            List<int> answer = new List<int>();

            int defaultTime = fees[0];
            int defaultCharge = fees[1];
            int unitTime = fees[2];
            int unitCharge = fees[3];

            List<int> times = new List<int>();
            List<int> carNumb = new List<int>();
            List<bool> checkOut = new List<bool>();

            for (int i = 0; i < records.Length; i++)
            {
                string[] temp = records[i].Split(' ');
                if (temp[2] == "IN")
                {
                    string[] timeSplit = temp[0].Split(':');
                    int timeTemp = int.Parse(timeSplit[0]) * 60 + int.Parse(timeSplit[1]);
                    times.Add(timeTemp);

                    int numbTemp = int.Parse(temp[1]);
                    carNumb.Add(numbTemp);

                    checkOut.Add(false);
                }
                else if (temp[2] == "OUT")
                {
                    for (int j = carNumb.Count - 1; j >= 0; j--)
                    {
                        if (carNumb[j] == int.Parse(temp[1]))
                        {
                            string[] timeSplit = temp[0].Split(':');
                            int timeTemp = int.Parse(timeSplit[0]) * 60 + int.Parse(timeSplit[1]);
                            times[j] = timeTemp - times[j];
                            checkOut[j] = true;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < checkOut.Count; i++)
            {
                if (checkOut[i] == false)
                {
                    int timeTemp = 1439;
                    times[i] = timeTemp - times[i];
                }
            }

            for (int i = 0; i < carNumb.Count; i++)
            {
                for (int j = carNumb.Count - 1; j >= 0; j--)
                {
                    if (carNumb[i] == carNumb[j] && i != j)
                    {
                        times[i] += times[j];
                        times.RemoveAt(j);
                        carNumb.RemoveAt(j);
                    }
                }
            }

            int smallNumbIndex;
            int carNumbTemp;

            for (int i = carNumb.Count - 1; i >= 0; i--)
            {
                carNumbTemp = carNumb[i];
                smallNumbIndex = i;

                for (int j = carNumb.Count - 1; j >= 0; j--)
                {
                    if (carNumbTemp > carNumb[j])
                    {
                        carNumbTemp = carNumb[j];
                        smallNumbIndex = j;
                    }
                }

                if (times[smallNumbIndex] <= defaultTime)
                {
                    answer.Add(defaultCharge);
                }
                else if (times[smallNumbIndex] > defaultTime)
                {
                    times[smallNumbIndex] -= defaultTime;
                    int multiple = times[smallNumbIndex] / unitTime;

                    if (times[smallNumbIndex] % unitTime != 0)
                    {
                        multiple += 1;
                    }

                    answer.Add(defaultCharge + unitCharge * multiple);
                }

                times.RemoveAt(smallNumbIndex);
                carNumb.RemoveAt(smallNumbIndex);
            }

            return answer;
        }
    }
}
