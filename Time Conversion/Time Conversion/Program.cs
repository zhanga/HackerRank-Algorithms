using System;

class Solution
{
    static string timeConversion(string s)
    {
        string meridiemInfo = s.Substring(8, 2);
        int hours = Convert.ToInt32(s.Substring(0, 2));
        if (meridiemInfo == "PM" && hours != 12)
        {
            hours += 12;
            s = hours + (s.Substring(2, 6));
        }
        else if (meridiemInfo == "AM" && hours == 12)
        {
            s = "00" + (s.Substring(2, 6));
        }
        else
        {
            s = s.Substring(0, 8);
        }
        return (s);
    }

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}