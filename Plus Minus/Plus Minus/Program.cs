using System;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
        double positive = 0;
        double negative = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
            {
                positive++;
            }
            else if (arr[i] < 0)
            {
                negative++;
            }
        }
        Console.WriteLine(positive / n);
        Console.WriteLine(negative / n);
        Console.WriteLine((n - (positive + negative)) / n);
    }
}
