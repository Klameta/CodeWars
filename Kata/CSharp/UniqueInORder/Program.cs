using System.Collections.Generic;
int[] arr = {1, 2, 2, 3, 3};
Console.WriteLine("."+string.Join("", Kata.UniqueInOrder(arr))+".");
public static class Kata
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        var filtred = iterable
            .Select((num, index) => new
                {
                    Current = num,
                    Next = iterable.ElementAtOrDefault(index + 1)
                })
            .Where(pair => !EqualityComparer<T>.Default.Equals(pair.Current, pair.Next))
            .Select(pair => pair.Current);

        return filtred;

    }
}