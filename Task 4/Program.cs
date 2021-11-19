using System;
using System.IO;
using System.Collections;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = File.ReadAllLines("input.txt");
            int index = int.Parse(info[0].Split(" ")[1])-1;
            DateTime[] dates = new DateTime[int.Parse(info[0].Split(" ")[0])];
            for (int i=0;i<info.Length-1;i++)
            {
                dates[i] = DateTime.Parse(info[i+1]);
            }
            for (int i=0;i<dates.Length-1;i++)
            {
                DateTime minDate = dates[i];
                int minI = i;
                for (int j=i+1;j<dates.Length;j++)
                {
                    if (dates[j]<minDate)
                    {
                        minDate = dates[j];
                        minI = j;
                    }
                }
                dates[minI] = dates[i];
                dates[i] = minDate;
            }
            for (int i=1;i<info.Length;i++)
            {
                if (dates[index]==DateTime.Parse(info[i]))
                {
                    File.WriteAllText("output.txt", info[i]);
                    break;
                }
            }
        }
    }
}