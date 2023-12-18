Console.WriteLine(Kata.Solution(10));

public static class Kata
{
    public static int Solution(int value)
    {
        value--;
        int sumOfMultiples = 0;
        while (value >= 3)
        {
            if (value % 3 == 0 || value % 5 == 0)
            {
                sumOfMultiples += value;
            }
            value--;
        }

        return sumOfMultiples;
    }
}