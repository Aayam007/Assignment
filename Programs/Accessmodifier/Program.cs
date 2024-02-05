using System;

public class AccessModifiersDemo
{
    // Public member accessible from anywhere
    public int PublicMember { get; set; }

    // Private member accessible only within the class
    private string PrivateMember { get; set; }

    // Protected member accessible within the class and derived classes
    protected double ProtectedMember { get; set; }

    // Internal member accessible within the same assembly
    internal bool InternalMember { get; set; }

    // Protected internal member accessible within the same assembly and by derived classes
    protected internal DateTime ProtectedInternalMember { get; set; }

    // Private protected member accessible within the same assembly and by derived classes
    private protected string PrivateProtectedMember { get; set; }

    // Constructor to initialize members
    public AccessModifiersDemo()
    {
        PublicMember = 42;
        PrivateMember = "Private Data";
        ProtectedMember = 3.14;
        InternalMember = true;
        ProtectedInternalMember = DateTime.Now;
        PrivateProtectedMember = "Restricted Access";
    }

    // Public method accessible from anywhere
    public void DisplayPublicData()
    {
        Console.WriteLine($"Public Member: {PublicMember}");
    }

    // Private method accessible only within the class
    private void DisplayPrivateData()
    {
        Console.WriteLine($"Private Member: {PrivateMember}");
    }

    // Protected method accessible within the class and derived classes
    protected void DisplayProtectedData()
    {
        Console.WriteLine($"Protected Member: {ProtectedMember}");
    }

    // Internal method accessible within the same assembly
    internal void DisplayInternalData()
    {
        Console.WriteLine($"Internal Member: {InternalMember}");
    }

    // Protected internal method accessible within the same assembly and by derived classes
    protected internal void DisplayProtectedInternalData()
    {
        Console.WriteLine($"Protected Internal Member: {ProtectedInternalMember}");
    }

    // Private protected method accessible within the same assembly and by derived classes
    private protected void DisplayPrivateProtectedData()
    {
        Console.WriteLine($"Private Protected Member: {PrivateProtectedMember}");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of AccessModifiersDemo
        AccessModifiersDemo demo = new AccessModifiersDemo();
        // Accessing members using different access modifiers
        demo.DisplayPublicData();
        // demo.DisplayPrivateData(); // This would result in a compilation error as it is private
        // demo.DisplayProtectedData(); // This would result in a compilation error as it is protected
        demo.DisplayInternalData();
        demo.DisplayProtectedInternalData();
        // demo.DisplayPrivateProtectedData(); // This would result in a compilation error as it is private protected
    }
}

