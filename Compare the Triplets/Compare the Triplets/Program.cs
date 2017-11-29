using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
    {
        int[] comparisonForA = new int[3] { a0, a1, a2 };
        int[] comparisonForB = new int[3] { b0, b1, b2 };
        int[] somethingToReturn = new int[6] { a0, a1, a2, b0, b1, b2 };
        int scoreForA = 0;
        int scoreForB = 0;
        for (int index = 0; index < 3; index++)
        {
            if (comparisonForA[index] > comparisonForB[index])
            {
                scoreForA++;
            }
            else if (comparisonForA[index] < comparisonForB[index])
            {
                scoreForB++;
            }
        }
        Console.WriteLine(scoreForA + " " + scoreForB);
        return somethingToReturn;
    }

    static void Main(String[] args)
    {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        int[] result = solve(a0, a1, a2, b0, b1, b2);
    }
}
