using System;
using System.Linq;

namespace _07.PersistentBugger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Persist.Persistence(999));
        }
    }
}

public class Persist
{
    public static int Persistence(long n)
    {
        var count = 0;
        var num = n;
        while (num > 9)
        {
            long result = 1;
            var temp = num.ToString();

            foreach (var currNum in temp)
            {
                result *= int.Parse(currNum.ToString());
            };
            num = result;
            count++;
        }

        return count;
    }
}