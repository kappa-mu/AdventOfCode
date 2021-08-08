using System;
using System.Linq;


namespace AdventOfCode
{
    static class D3TobogganTrajectory
    {
        static string path = @"D:\Technology\CSharp\AdventOfCodeData\Day3.txt";
        static string[] rows => Inputs.GetInput(path); 

        public static int P1TreeCount ()
        {
            int result = 0;

            for(int i=1; i<rows.Length; i++)
            {
                if(rows[i].Substring(i*3, 1) == "#")
                {
                    result++;
                }
            }
            return result;
        }
    }
}