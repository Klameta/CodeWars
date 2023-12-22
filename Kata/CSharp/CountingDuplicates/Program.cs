using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Kata.DuplicateCount(""));
    }
}

public class Kata
{
    public static int DuplicateCount(string str)
    {
        var dublicates = new Dictionary<char, int>();
        foreach (var letter in str.ToLower())
        {
            if (dublicates.ContainsKey(letter))
            {
                dublicates[letter]++;
            }
            else
            {
                dublicates.Add(letter, 1);
            }
        }
        var result = dublicates.Where(x => x.Value > 1);

        return result.Count();

    }
}