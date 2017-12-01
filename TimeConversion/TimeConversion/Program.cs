using System;
class Solution
{

    static string timeConversion(string s)
    {
        int timeValue = Convert.ToInt32(s.IndexOf(":"));
        if (s.Contains("PM"))
        {

        }

        else if (s.Contains("AM"))
        {

        }
        Console.WriteLine(timeValue);
        Console.ReadKey();
        return s;
    }

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
