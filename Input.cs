using System;

namespace AdventOfCode
{
    class Inputs
    {
        public static string[] GetInput(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }
    }
}