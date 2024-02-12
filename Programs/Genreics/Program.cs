using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch listTime = Stopwatch.StartNew();
        List<int> intList = new List<int>();
        for (int i = 0; i < 1000000; i++)
        {
            intList.Add(i);
        }
        listTime.Stop();
        Console.WriteLine("Time elapsed for List<int>: " + listTime.ElapsedMilliseconds + "ms");

        Stopwatch objectTime = Stopwatch.StartNew();
        List<object> objectList = new List<object>();
        for (int i = 0; i < 1000000; i++)
        {
            objectList.Add(i);
        }
        objectTime.Stop();
        Console.WriteLine("Time elapsed for List<object>: " + objectTime.ElapsedMilliseconds + "ms");

        Stopwatch genericsTime = Stopwatch.StartNew();
        GenericList<int> genericList = new GenericList<int>();
        for (int i = 0; i < 1000000; i++)
        {
            genericList.Add(i);
        }
        genericsTime.Stop();
        Console.WriteLine("Time elapsed for ListUsingGenerics<int>: " + genericsTime.ElapsedMilliseconds + "ms");
    }
}

class GenericList<T>
{
    private List<T> list = new List<T>();

    public void Add(T item)
    {
        list.Add(item);
    }
}
