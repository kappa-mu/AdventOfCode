using System;

namespace AdventOfCode
{
    static class D1ReportRepair
    {
        static string path = @"D:\Technology\CSharp\AdventOfCodeData\Day1.txt";
        static string[] rows => Inputs.GetInput(path); 

        public static long GetResultP1()
        {
            long result = 0;
            int[] numbers = new int[rows.Length];

            for(int i=0; i<rows.Length; i++)
            {
                numbers.SetValue(Convert.ToInt32(rows[i]), i);
            }

            for(int i=0; i<numbers.Length; i++)
            {
                for(int j=i; j<numbers.Length; j++)
                {
                    if(numbers[i] + numbers[j] == 2020)
                    {
                        result = numbers[i]*numbers[j];
                        break;
                    }
                }
            }
            return result;
        }

        public static long GetResultP2()
        {
            long result = 0;
            int[] numbers = new int[rows.Length];

            for(int i=0; i<rows.Length; i++)
            {
                numbers.SetValue(Convert.ToInt32(rows[i]), i);
            }

            for(int i=0; i<numbers.Length; i++)
            {
                for(int j=i; j<numbers.Length; j++)
                {
                    for(int k=j; k<numbers.Length; k++)
                    {
                        if(numbers[i] + numbers[j] + numbers[k] == 2020)
                        {
                            result = numbers[i]*numbers[j]*numbers[k];
                            break;
                        }
                    }
                }
            }
            return result;
        }
    }
}