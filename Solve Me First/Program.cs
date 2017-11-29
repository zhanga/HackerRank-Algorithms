using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static int solveMeFirst(int a, int b)
    {
        return a + b;
    }

    static void Main(String[] args)
    {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(solveMeFirst(val1, val2));
    }
}
