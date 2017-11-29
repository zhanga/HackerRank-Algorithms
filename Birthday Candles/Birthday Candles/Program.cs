using System;
class Solution
{

    static int birthdayCakeCandles(int n, int[] ar)
    {
        int candleCounter = 0;
        int tallestCandle = 0;
        for (int i = 0; i < n; i++)
        {
            if (ar[i] > tallestCandle)
            {
                tallestCandle = ar[i];
                candleCounter = 1;
            }
            else if (ar[i] == tallestCandle)
            {
                candleCounter++;
            }
        }
        return candleCounter;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
        Console.WriteLine(birthdayCakeCandles(n, ar));
    }
}
