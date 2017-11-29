using System;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for (int a_i = 0, reverseIndex = n - 1; a_i < n; a_i++, reverseIndex--)
        {
            a[a_i] = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            if (a_i > 0)
            {
                a[0][0] = a[0][0] + a[a_i][a_i];
                a[0][n - 1] = a[0][n - 1] + a[a_i][reverseIndex];
            }
        }
        a[0][0] = Math.Abs(a[0][0] - a[0][n - 1]);
        Console.WriteLine(a[0][0]);
        Console.ReadKey();
    }
}
