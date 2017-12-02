using System;
class Solution
{
    static int[] solve(int[] grades)
    {
        double[] toRound = Array.ConvertAll(grades, x => (double)x);
        double temp;
        for (int i = 0; i < grades.Length; i++)
        {
            if (toRound[i] > 37)
            {
                temp = Math.Round(toRound[i] / 5) * 5;
                if(temp > toRound[i])
                {
                    toRound[i] = temp;
                }
            }
        }
        grades = Array.ConvertAll(toRound, x => (int)x);
        return grades;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for (int i = 0; i < n; i++)
        {
            grades[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));
    }
}
