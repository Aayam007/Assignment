using System;

public class ParentClass
{
   public string Message { get; set; }
    public ParentClass(string message)
    {
            Message = message;  
    }
    public void DisplayMessage()
    {
        Console.WriteLine(Message);
        Console.WriteLine("Message from the ParentClass");
    }
}

public class ChildClass : ParentClass
{
    public string ChildMessage { get; set; }
    public ChildClass(string message) : base(message)
    {
            ChildMessage = Message;
    }
    public void DisplayChildMessage()
    {
        base.DisplayMessage();
        Console.WriteLine("Message from the ChildClass");
    }
}

class Program
{
    static void Main()
    {
        string message = "Hello from Main";
        ChildClass child = new ChildClass(message);

        child.DisplayChildMessage();
        child.DisplayMessage();
        
    }
}
