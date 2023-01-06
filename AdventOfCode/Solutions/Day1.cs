using AdventOfCode.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode.Solutions
{
    public class Day1 : ISolution
    {
        public void Solve()
        {
            string str = File.ReadAllText("C:\\Users\\Adit\\source\\repos\\Abracadabra\\AdventOfCode\\input.txt");
            var strSplit = Regex.Split(str, "\r\n\r\n");
            int max1 = 0;
            int max2 = 0;
            int max3 = 0;
            foreach (var x in strSplit)
            {
                var str2split = Regex.Split(x, "\r\n");
                int numVal = 0;
                foreach (var x2 in str2split)
                {
                    numVal += int.Parse(x2);
                }
                if (numVal > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = numVal;
                }
                else if (numVal > max2)
                {
                    max3 = max2;
                    max2 = numVal;
                }
                else if (numVal > max3)
                {
                    max3 = numVal;
                }
            }
            Console.WriteLine(max1 + max2 + max3);
        }

    }
}
