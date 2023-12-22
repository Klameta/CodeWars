using System.Collections.Generic;
using System.Linq;
using System;


namespace _04.FindTheParityOutlier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 0, 100, 4, 11, 2602, 36 };
            Console.WriteLine(Kata.Find(new int[] { 160, 3, 1719, 19, 11, 13, -21 }));
        }
    }
}

public class Kata
{
    public static int Find(int[] integers)
    {
        var evens = integers.Where(x => x % 2 == 0).ToArray();
        var odds = integers.Where(x => x % 2 == 1).ToArray();

        return evens.Count() == 1 ? evens[0] : odds[0];
    }
}