using AdventOfCode.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Solutions
{
    public static class SolutionFactory
    {
        public static ISolution? GetSolution(string userInput)
        {
            float userInputAsFloat = float.Parse(userInput);
            ISolution solution;
            switch(userInputAsFloat)
            {
                case 1:
                    solution = new Day1();
                    break;
                case 2:
                    solution = new Day2();
                    break;
                case 2.2F:
                    solution = new Day2_2();
                    break;
                case 3:
                    solution = new Day3();
                    break;
                //Add new cases here before default
                //....
                default:
                    solution = null;
                    break;
            }
            return solution;
        }
    }
}
