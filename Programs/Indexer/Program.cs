using System;

class MyCollection
{
    private string[] data = new string[5];

    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < data.Length)
                return data[index];
            else
                return "Index out of bounds";
        }
        set
        {
            if (index >= 0 && index < data.Length)
                data[index] = value;
            else
                Console.WriteLine("Index out of bounds. Cannot set value.");
        }
    }
}

class Program
{
    static void Main()
    {
        MyCollection myCollection = new MyCollection();

        myCollection[0] = "Value at index 0";
        myCollection[1] = "Value at index 1";

        Console.WriteLine(myCollection[0]); 
        Console.WriteLine(myCollection[1]); 
        Console.WriteLine(myCollection[6]); 
    }
}
