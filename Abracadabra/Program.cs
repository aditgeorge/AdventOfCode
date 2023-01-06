using System;

public class Program
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        while (t > 0)
        {
            int n = int.Parse(Console.ReadLine());
            Func(n);
            t--;
        }
    }
    public static void Func(int n)
    {
        if (n <= 3)
        {
            PrintIt(new int[] { 0, -1 });
            return;
        }
        else if (n == 4)
        {
            PrintIt(new int[] { 0,2, 4, 1, 3 });
            return;
        }

        int len = n;
        int[] arr = new int[n + 1];
        while (len > 0)
        {
            arr[len] = len;
            len--;
        }
        int[] ans = new int[n + 1];
        ans[1] = arr[1];
        arr[1] = 0;
        for (int i = 2; i <= n; i++)
        {
            int index = ans[i - 1] + 2;
            index = index.NMod(n);
            while (arr[index] == 0)
            {
                index++;
                index = index.NMod(n);
            }
            arr[index] = 0;
            if (Math.Abs(index - ans[i - 1]) < 2)
                throw new Exception("Logic Failure");
            ans[i] = index;
        }
        PrintIt(ans);
    }
    public static void PrintIt(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

}
public static class Extensions
{
    public static int NMod(this int x, int n)
    {
        while (x > n)
            x -= n;
        return x;
    }
}
