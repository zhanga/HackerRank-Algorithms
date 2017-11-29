using System;
class Program
{
    static string[] createStringArray(short numberOfElements)
    {
        string[] stringsToCreate = new string[numberOfElements];
        for (int i = 0; i < numberOfElements; i++)
        {
            stringsToCreate[i] = Console.ReadLine().Trim();
            if (stringsToCreate[i].Length > 20)
            {
                Console.WriteLine("Sorry, this string length must not exceed 20.");
                Console.ReadKey();
                Environment.Exit(1);
            }
        }
        return stringsToCreate;
    }

    static int[] compareStringsAndQueries(short n, short q, string[] strings, string[] queries)
    {
        int[] matches = new int[q];
        for (short indexOfN = 0; indexOfN < n; indexOfN++)
        {
            for (short indexOfQ = 0; indexOfQ < q; indexOfQ++)
            {
                if (strings[indexOfN] == queries[indexOfQ])
                {
                    matches[indexOfQ]++;
                }
            }
        }
        return matches;
    }

    static void Main(string[] args)
    {
        short n = Convert.ToInt16(Console.ReadLine()); // for strings
        if (n > 1000)
        {
            Console.WriteLine("Sorry, this number must not exceed 1000.");
            Console.ReadKey();
            Environment.Exit(1);
        }
        string[] stringsToCompare = createStringArray(n);
        short q = Convert.ToInt16(Console.ReadLine()); // for queries
        if (q > 1000)
        {
            Console.WriteLine("Sorry, this number must not exceed 1000.");
            Console.ReadKey();
            Environment.Exit(1);
        }
        string[] queriesToCompare = createStringArray(q);

        int[] matchesAfterComparison = compareStringsAndQueries(n, q, stringsToCompare, queriesToCompare);
        for (int i = 0; i < q; i++)
        {
            Console.WriteLine(matchesAfterComparison[i]);
        }
        Console.ReadKey();
    }
}
