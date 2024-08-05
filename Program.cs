Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine("Hello, World!");

List<int> list = [1, 2, 3, 4, 5, 6, 7, 8, 9];

// var queryCount = list.Count();
// Console.WriteLine(queryCount);

// var queryTake = list.Take(3);
// var querySkip = list.Skip(3);
// var queryToArray = list.ToArray();
// var queryAppend = list.Append(3);
var queryPrepend = list.Prepend(3);
foreach (var item in queryPrepend)
    Console.WriteLine(item);

public static class Enumerable
{
    public static IEnumerable<T> Take<T>(this IEnumerable<T> collection, int count) 
    {
        var it = collection.GetEnumerator();
        for (int i = 0; i < count && it.MoveNext(); i++)
        {
            yield return it.Current;
        }
    }

    public static IEnumerable<T> Skip<T>(this IEnumerable <T> collection, int count)
    {
        var it = collection.GetEnumerator();
        for (int i = 0; i < count && it.MoveNext(); i++)
        {
            continue;
        }

        while (it.MoveNext())
        {
            yield return it.Current;
        }
    }

    public static int Count<T>(this IEnumerable <T> collection)
    {
        var it = collection.GetEnumerator();
        var cont = 0;
        foreach (var item in collection)
        {
            cont++;
        }

        return cont;
    }

    public static T[] ToArray<T>(this IEnumerable <T> collection)
    {
        T[] array = new T[collection.Count()];
        int index = 0;
        foreach (var item in collection)
        {
            array[index] = item;
            index++;
        }

        return array;
    }

    public static T[] Append<T>(this IEnumerable <T> collection, T text)
    {
        T[] array = new T[collection.Count() + 1];
        int index = 0;
        foreach (var item in collection)
        {
            array[index] = item;
            index++;
        }

        array[index++] = text;

        return array;
    }

    public static IEnumerable<T> Prepend<T>(this IEnumerable <T> collection, T text)
    {
        T[] array = new T[collection.Count() + 1];
        int index = 1;
        foreach (var item in collection)
        {
            array[index] = item;
            index++;
        }

        array[0] = text;

        return array;
    }
}