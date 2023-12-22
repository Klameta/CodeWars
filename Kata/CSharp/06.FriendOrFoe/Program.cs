using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FriendOrFoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Ryan", "Kieran", "Mark", "Jimmy" };
            Console.WriteLine(string.Join(" ",Kata.FriendOrFoe(arr)));
        }
    }
}

public static class Kata
{
    public static IEnumerable<string> FriendOrFoe(string[] names)
    {
        return names.Where(x => x.Length ==4).ToList();
    }
}