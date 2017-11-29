using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static long[] performSort(long[] arrayOfNumbers)
    {
        long temp = 0;
        for (int firstIndex = 0; firstIndex < 5; firstIndex++)
        {
            for (int secondIndex = 0; secondIndex < 5; secondIndex++)
            {
                if (arrayOfNumbers[firstIndex] > arrayOfNumbers[secondIndex])
                {
                    temp = arrayOfNumbers[secondIndex];
                    arrayOfNumbers[secondIndex] = arrayOfNumbers[firstIndex];
                    arrayOfNumbers[firstIndex] = temp;
                }
            }
        }
        return arrayOfNumbers;
    }

    static void Main(String[] args)
    {
        long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int64.Parse);
        arr = performSort(arr);
        Console.WriteLine((arr[1] + arr[2] + arr[3] + arr[4]) + " " + (arr[0] + arr[1] + arr[2] + arr[3]));
    }
}
