using AdventOfCode.Interfaces;
using MagicTools;

namespace AdventOfCode.Solutions
{
    public class Day2 : ISolution
    {
        public static Dictionary<string, int> signToNum = new Dictionary<string, int>
        {
            { "X", 0 },
            { "Y", 1 },
            { "Z", 2 },
            { "A", 0 },
            { "B", 1 },
            { "C", 2 }
        };
        public static Dictionary<string, int> signToPoints = new Dictionary<string, int>
        {
            { "X",1 },
            { "Y", 2 },
            { "Z", 3 }
        };
        enum outcomeToPoints { Lost = 0, Draw = 3, Win = 6 };
        public void Solve()
        {
            var fileData = File.ReadAllLines("C:\\Users\\Adit\\source\\repos\\Abracadabra\\AdventOfCode\\Input\\Day2Input.txt");
            var totalPoints = 0;
            foreach (var line in fileData)
            {
                (string player1, string player2) = line.Split(' ');
                totalPoints += DetermineGame(player1, player2) + signToPoints[player2];
            }
            Console.WriteLine(totalPoints);
        }
        public static int DetermineGame(string player1, string player2)
        {
            int p1Num = signToNum[player1];
            int p2Num = signToNum[player2];
            if (p1Num == p2Num)
                return (int)outcomeToPoints.Draw;
            else if (p2Num == (p1Num + 1) % 3)
                return (int)outcomeToPoints.Win;
            else
                return (int)outcomeToPoints.Lost;
        }

    }

    public class Day2_2 : ISolution
    {
        public static Dictionary<string, int> signToNum = new Dictionary<string, int>
        {
            { "A", 0 },
            { "B", 1 },
            { "C", 2 }
        };
        public static Dictionary<int, int> signNumToPoints = new Dictionary<int, int>
        {
            { 0, 1 },
            { 1, 2 },
            { 2, 3 }
        };
        enum outcomeToPoints { Lost = 0, Draw = 3, Win = 6 };
        public static Dictionary<string, int> signToOutcome = new Dictionary<string, int>
        {
            {"X",  (int)outcomeToPoints.Lost},
            {"Y", (int)outcomeToPoints.Draw},
            {"Z", (int)outcomeToPoints.Win}
        };
        public void Solve()
        {
            var lines = File.ReadAllLines("C:\\Users\\Adit\\source\\repos\\Abracadabra\\AdventOfCode\\Input\\Day2Input.txt");
            int sumTotal = 0;
            foreach (var line in lines)
            {
                (var player1Sign, var outcome) = line.Split(' ');
                int sign = signToNum[player1Sign];
                switch (outcome)
                {
                    case "X":
                        sign = (sign + 2) % 3;
                        break;
                    case "Y":
                        break;
                    case "Z":
                        sign = (sign + 1) % 3;
                        break;
                }
                sumTotal += signToOutcome[outcome] + signNumToPoints[sign];
            }
            Console.WriteLine(sumTotal);
        }

    }
}
