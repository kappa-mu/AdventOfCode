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
            return TreeCount(3, 1);
        }


        public static long P2TreeMultiplyCount()
        {
            long treeCount1 = TreeCount(1,1);
            long treeCount2 = TreeCount(3,1);
            long treeCount3 = TreeCount(5,1);
            long treeCount4 = TreeCount(7,1);
            long treeCount5 = TreeCount(1,2);

            long result = treeCount1*treeCount2*treeCount3*treeCount4*treeCount5;
            return result;
        }

        public static int TreeCount(int right, int down)
        {
            int result = 0;
            List<string> treeList = rows.ToList();
            int counter = 1;
            int columnIndex = 0;

            for(int i = down; i < treeList.Count(); i += down)
            {
                columnIndex = counter*right;
                counter++;
                if(columnIndex  >= treeList[i].Length)
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