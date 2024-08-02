using System.Collections;

Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine("Hello, World!");



// public interface IEnumerator<T>
// {
//     bool MoveNext();
//     T Current { get; }
// }



// public interface IEnumerable<T>
// {
//     IEnumerator<T> GetEnumerator();
// }



// printValues(new int[10]);

// void printValues<T>(IEnumerable<T> coll)
// {
//     var it = coll.GetEnumerator();
//     while (it.MoveNext())
//     {
//         var value = it.Current;
//         Console.WriteLine(value);
//     }
// }



public class MyList<T> : ICollection<T>
{

    class MyNode
    {
        public T Data { get; set; }
        public MyNode Next { get; set; }
    }
    MyNode first = null;
    MyNode last = null;

    int count = 0;

    public int Count => count;

    public bool IsReadOnly => false;

    public void Add(T item)
    {
        var newNode = new MyNode { Data = item };
        if (first == null)
        {
            first = last = newNode;
        }
        else 
        {
            first.Next = newNode;
            first = newNode;    
        }

        count++;
    }

    public void Clear()
    {
        first = last = null;
        count = 0;
    }

    public bool Contains(T item)
    {
        var current = first;
        while (first != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Data, item))
                return true;

            current = current.Next;
        }

        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array));
        if (arrayIndex < 0)
            throw new ArgumentOutOfRangeException(nameof(arrayIndex));
        if (arrayIndex + count > array.Length)
            throw new ArgumentException("The array is not large enough.");

        var current = first;
        while (current != null)
        {
            array[arrayIndex++] = current.Data;
            current = current.Next;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new MyIterator(first);
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class MyIterator<T> : IEnumerator<T>
{
    public T Current => throw new NotImplementedException();

    object IEnumerator.Current => throw new NotImplementedException();

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}