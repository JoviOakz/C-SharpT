// Console.BackgroundColor = ConsoleColor.Magenta;
// Console.WriteLine("Hello, World!");

// ------------------------------------------------------------------------------------------------------------------------------------------

// List<int> list = [1, 2, 3, 4, 5, 6, 7, 8, 9];

// var queryCount = list.Count();
// Console.WriteLine(queryCount);

// Console.WriteLine();

// var queryTake = list.Take(3);
// var querySkip = list.Skip(3);
// var queryToArray = list.ToArray();
// var queryAppend = list.Append(3);
// var queryPrepend = list.Prepend(3);
// var queryEmpty = list.Empty();
// // var queryFirstOrDefault = list.FirstOrDefault();
// // var queryChunk = list.Chunk(3);
// // var queryZip = list.Zip();
// foreach (var item in queryEmpty)
//     Console.WriteLine(item);

// public static class Enumerable
// {
//     public static IEnumerable<T> Take<T>(this IEnumerable<T> collection, int count) 
//     {
//         var it = collection.GetEnumerator();
//         for (int i = 0; i < count && it.MoveNext(); i++)
//         {
//             yield return it.Current;
//         }
//     }

//     public static IEnumerable<T> Skip<T>(this IEnumerable <T> collection, int count)
//     {
//         var it = collection.GetEnumerator();
//         for (int i = 0; i < count && it.MoveNext(); i++)
//         {
//             continue;
//         }

//         while (it.MoveNext())
//         {
//             yield return it.Current;
//         }
//     }

//     public static int Count<T>(this IEnumerable <T> collection)
//     {
//         var it = collection.GetEnumerator();
//         var cont = 0;
//         foreach (var item in collection)
//         {
//             cont++;
//         }

//         return cont;
//     }

//     public static T[] ToArray<T>(this IEnumerable <T> collection)
//     {
//         T[] array = new T[collection.Count()];
//         int index = 0;
//         foreach (var item in collection)
//         {
//             array[index] = item;
//             index++;
//         }

//         return array;
//     }

//     public static IEnumerable<T> Append<T>(this IEnumerable <T> collection, T text)
//     {
//         var it = collection.GetEnumerator();
//         for (int i = 0; i < collection.Count() && it.MoveNext(); i++)
//         {
//             yield return it.Current;
//         }

//         yield return text;
//     }

//     public static IEnumerable<T> Prepend<T>(this IEnumerable <T> collection, T text)
//     {
//         yield return text;

//         var it = collection.GetEnumerator();
//         for (int i = 0; i < collection.Count() && it.MoveNext(); i++)
//         {
//             yield return it.Current;
//         }
//     }

//     public static bool Empty<T>(this IEnumerable <T> collection)
//     {}

//     // public static T FirstOrDefault<T>(this IEnumerable <T> collection)
//     // {}

//     // public static IEnumerable<T[]> Chunk<T>(this IEnumerable <T> collection, int size)
//     // {}

//     // public static IEnumerable<(T, R)> Zip<T, R>(this IEnumerable <T> collection, IEnumerable<R> other)
//     // {}
// } 

// ------------------------------------------------------------------------------------------------------------------------------------------

// Action<string> print = Console.WriteLine;
// print("Hello World!");

// ------------------------------------------------------------------------------------------------------------------------------------------

// Func<int, int, int> sum = (a, b) => a + b;
// var result = sum(1, 2);

// Console.WriteLine(result);

// public delegate R Func<T, R>(T obj);

// ------------------------------------------------------------------------------------------------------------------------------------------

// var chamaNVezes = (Action func, int n) =>
// {
//     for (int i = 0; i < n; i++)
//         func();
// };

// chamaNVezes(() => Console.WriteLine("Olá Mundo!"), 100);

// ------------------------------------------------------------------------------------------------------------------------------------------

// int[] valores = [1, 2, 3, 4, 5, 6, 7, 8, 9];

// Func<int[], int, Func<int, int[]>> paginacao = (dados, tamanho) =>
// {
//     return (pagina) =>
//     {
//         int[] paginaDados = new int[tamanho];
//         Array.Copy(
//             dados, tamanho * pagina,
//             paginaDados, 0,
//             tamanho
//         );

//         return paginaDados;
//     };
// };

// var paginas = paginacao(valores, 4);

// var dadosDaPagina2 = paginas(2);

// ------------------------------------------------------------------------------------------------------------------------------------------

// Func<Func<int>> closure = () =>
// {
//     int count = 0;
//     return () => ++count;
// };

// var contador = closure();
// Console.WriteLine(contador());
// Console.WriteLine(contador());
// Console.WriteLine(contador());

// ------------------------------------------------------------------------------------------------------------------------------------------

// Func<object, (object data, Action<object> setData)> useState = (object data) =>
// {
//     var value = data;
//     return (value, (object newValue) => value = newValue);
// };

// var (value, setValue) = useState(8);
// setValue(12);

// ------------------------------------------------------------------------------------------------------------------------------------------

// List<int> minhaLista = [1, 2, 3, 4, 5, 6, 7, 8, 9];

// var pares = minhaLista.Where((element) => element % 2 == 0);

// public static class Enumerable
// {
//     public static IEnumerable<T> Where<T>(
//         this IEnumerable<T> collection,
//         Func<T, bool> filter
//     )
//     {
//         foreach (var item in collection)
//         {
//             if (filter(item))
//                 yield return item;
//         }
//     }
// }

// ------------------------------------------------------------------------------------------------------------------------------------------

public static class Enumerable
{
    public static IEnumerable<R> Select<T, R>(
        this IEnumerable<T> collection,
        Func<T, R> mapper
    )
    {
        
    }
}