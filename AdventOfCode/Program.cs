using AdventOfCode.Interfaces;
using AdventOfCode.Solutions;
using MagicTools.DataStructures;
using System.Collections.Immutable;
using System.Text.RegularExpressions;

namespace AdventOfCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            ISolution? solution;
        Loop:
            Console.WriteLine("Please enter AoC problem (eg: 1, 1.2), or Q to quit:");
            var userInput = Console.ReadLine();
            if (userInput == null)
            {
                Console.WriteLine("Empty userinput, try again.");
                goto Loop;
            }
            else if (Regex.IsMatch(userInput, "(^q$)|(^Q$)|(^quit$)|(^Quit$)|(^QUIT$)"))
            {
                Console.WriteLine("Bye bye");
                return;
            }
            else if (Regex.IsMatch(userInput, "[a-zA-Z]"))
            {
                Console.WriteLine("No alphabets allowed in input, try again.");
                goto Loop;
            }
            solution = SolutionFactory.GetSolution(userInput);
            if (solution == null)
            {
                Console.WriteLine("Invalid problem number, try again.");
                goto Loop;
            }
            solution.Solve();
            Console.WriteLine("Thank You :)");
        }
    }
}