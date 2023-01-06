using static System.Math;
namespace Puzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {13, 16, 11, 10, 17, 10, 6, 2};
            foreach(int x in arr)
            {
                Console.WriteLine((char)(x+96));
            }
            return;
            string str1 = "original";
            string str2 = "utcmnf";
            int[] arr1 = new int[str1.Length];
            int[] arr2 = new int[str2.Length];
            int iter = 0;
            foreach (char item in str1)
            {
                arr1[iter++] = item-96;
                Console.WriteLine(arr1[iter - 1]);
            }
            return;
            iter = 0;
            foreach(char item in str2)
            {
                arr2[iter++] = item - 96;
            }
            int[,] mat = new int[arr1.Length, arr1.Length];
            Console.Write("      ");
            foreach (int j in arr2)
            {
                Console.Write(PrintNum(j) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(PrintNum(arr1[i]) + " | ");
                for (int j = 0; j < arr2.Length; j++)
                {
                    Console.Write(PrintNum(arr1[i] - arr2[j]) + " ");
                    mat[i, j] = arr1[i] - arr2[j];
                }
                Console.WriteLine(" |");
            }
            
            PrintMat(mat, arr1.Length, 1);
            PrintMat(mat, arr1.Length, 2);
        }

        private static void PrintMat(int[,] mat, int len, int item)
        {
            Console.WriteLine("\n\n=============================================\n");
            for (int i = 0; i < len; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < len; j++)
                {
                    if (Abs(mat[i, j]) == item)
                        Console.Write(PrintNum(mat[i, j]) + " ");
                    else
                        Console.Write(PrintNum(0) + " ");
                }
                Console.WriteLine(" |");
            }
        }

        static string PrintNum(int num)
        {
            return num.ToString().PadLeft(3, ' ');
        }
    }
}