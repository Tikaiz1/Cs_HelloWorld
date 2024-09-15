namespace HelloWorld;

internal class Person
{
    public string FirstName { get; init; } = "";
    public int Age { get; init; }
    public string LastName { get; init; } = "";
    
    public override string ToString()
    {
        Console.WriteLine($"Length= {FirstName.Length}");
        return $"{FirstName} {LastName} is {Age} years old.";
    }

    public void DoIt()
    {
        Console.WriteLine("Hello World!");
    }
}