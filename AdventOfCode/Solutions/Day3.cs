using AdventOfCode.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Solutions
{
    public class Day3 : ISolution
    {
        public void Solve()
        {
            var lines = File.ReadAllLines("C:\\Users\\Adit\\source\\repos\\Abracadabra\\AdventOfCode\\Input\\Day3Input.txt");
            int totalSum = 0;
            HashSet<char> charSet1 = new HashSet<char>();
            HashSet<char> charSet2 = new HashSet<char>();
            foreach (var line in lines)
            {
                char[] charArr = line.ToCharArray();
                for(int i = 0; i < charArr.Length/2; i++)
                    charSet1.Add(charArr[i]);
                for (int i = charArr.Length / 2; i < charArr.Length; i++)
                    charSet2.Add(charArr[i]);
                foreach (char char1 in charSet1)
                {
                    foreach (char char2 in charSet2)
                    {
                        if (char1 == char2)
                        {
                            int charAsNum = (int)char1;
                            if (charAsNum < 90)
                                charAsNum -= 38;
                            else
                                charAsNum -= 96;
                            totalSum += charAsNum;
                        }
                    }
                }
                charSet1.Clear();
                charSet2.Clear();
            }
            Console.WriteLine(totalSum);
        }
    }
}
