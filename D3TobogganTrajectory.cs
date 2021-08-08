using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace AdventOfCode
{
    static class D3TobogganTrajectory
    {
        static string path = @"D:\Technology\CSharp\AdventOfCodeData\Day3.txt";
        static string[] rows => Inputs.GetInput(path); 

        public static int P1TreeCount ()
        {
            int result = 0;
            List<string> treeList = rows.ToList();

            for(int i=1; i<treeList.Count(); i++)
            {
                int columnIndex = i*3;
                if(columnIndex  >= rows[i].Length)
                {
                    treeList[i] = AddToTheString(treeList[i], columnIndex);
                }
                if(treeList[i].Substring(columnIndex, 1) == "#")
                {
                    result++;
                }
            }
            return result;
        }

        static string AddToTheString(string s, int count)
        {
            if(s.Length > count)
                return s;
            
            return AddToTheString(s+s, count);           
        }
    }
}