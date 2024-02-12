using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Arrays
        int[] array = { 1, 2, 3, 4, 5 };

        // Lists
        List<string> list = new List<string>();
        list.Add("apple");
        list.Add("banana");
        list.Add("orange");

        // Dictionaries
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "One");
        dictionary.Add(2, "Two");
        dictionary.Add(3, "Three");

        // Sets
        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(2);
        set.Add(3);

        // Queues
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("first");
        queue.Enqueue("second");
        queue.Enqueue("third");

        // Stacks
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Linked Lists
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);

        // SortedLists
        SortedList<int, string> sortedList = new SortedList<int, string>();
        sortedList.Add(3, "Three");
        sortedList.Add(1, "One");
        sortedList.Add(2, "Two");

        // Output
        Console.WriteLine("Array:");
        foreach (var item in array)
            Console.WriteLine(item);

        Console.WriteLine("\nList:");
        foreach (var item in list)
            Console.WriteLine(item);

        Console.WriteLine("\nDictionary:");
        foreach (var pair in dictionary)
            Console.WriteLine($"{pair.Key}: {pair.Value}");

        Console.WriteLine("\nSet:");
        foreach (var item in set)
            Console.WriteLine(item);

        Console.WriteLine("\nQueue:");
        while (queue.Count > 0)
            Console.WriteLine(queue.Dequeue());

        Console.WriteLine("\nStack:");
        while (stack.Count > 0)
            Console.WriteLine(stack.Pop());

        Console.WriteLine("\nLinked List:");
        foreach (var item in linkedList)
            Console.WriteLine(item);

        Console.WriteLine("\nSorted List:");
        foreach (var pair in sortedList)
            Console.WriteLine($"{pair.Key}: {pair.Value}");
    }
}
