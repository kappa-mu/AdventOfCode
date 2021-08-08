using System;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode
{
    static class D2PasswordPhilosphy
    {
        static string path = @"D:\Technology\CSharp\AdventOfCodeData\Day2.txt";
        static string[] rows => Inputs.GetInput(path); 

        public static int GetValidPasswordCountP1()
        {
            int count = 0;

            foreach(string row in rows)
            {
                string[] passwordDetails = row.Split(':');
                string passwordCritreria = passwordDetails[0];
                string password = passwordDetails[1].TrimStart();
                string occurance = passwordCritreria.Split(' ')[0];
                string passwordChar = passwordCritreria.Split(' ')[1];
                List<int> minMaxOccurance = ExtractDetails(occurance);

                int minOccurance = minMaxOccurance[0];
                int maxOccurance = minMaxOccurance[1];
                
                int numOfChar = password.Count(x => x == passwordChar.ToCharArray()[0]);
                if(numOfChar >= minOccurance && numOfChar <= maxOccurance)
                {
                    count++;
                }
            }

            return count;
        }

        public static int GetValidPasswordCountP2()
        {
            int count = 0;

            foreach(string row in rows)
            {
                string[] passwordDetails = row.Split(':');
                string passwordCritreria = passwordDetails[0];
                string password = passwordDetails[1].TrimStart();
                string position = passwordCritreria.Split(' ')[0];
                string passwordChar = passwordCritreria.Split(' ')[1];
                List<int> positions = ExtractDetails(position);

                int firstPosition = positions[0];
                int secondPosition = positions[1];
                
                if(password.Substring(firstPosition-1, 1).Equals(passwordChar) ^
                   password.Substring(secondPosition-1, 1).Equals(passwordChar))
                {
                    count++;
                }
            }

            return count;
        }

        static List<int> ExtractDetails(string minMax)
        {
            string[] minMaxDetails = minMax.Split('-');
            return minMaxDetails.Select(x => Convert.ToInt32(x)).ToList();
        }
    }
}