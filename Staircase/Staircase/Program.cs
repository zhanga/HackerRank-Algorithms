using System;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int differenceOfN = 0;
        for (int i = 0; i < n; i++)
        {
            differenceOfN = 1;
            while (differenceOfN < n - i)
            {
                Console.Write(" ");
                differenceOfN++;
            }
            while (differenceOfN != n)
            {
                Console.Write("#");
                differenceOfN++;
            }
            Console.WriteLine("#");
            differenceOfN = 0;
        }
        Console.ReadKey();
    }
}