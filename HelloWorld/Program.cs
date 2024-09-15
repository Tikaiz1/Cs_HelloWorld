using HelloWorld;

int x = 5;
int y = 10;
int sum = x + y + 4;
double root = Math.Sqrt(sum);
Console.WriteLine(root);
Console.WriteLine(x + "+" + y + " = " + sum);
Console.WriteLine($"{x}+{y}={sum}");

var person = new Person
{
    FirstName = "John",
    LastName = "Doe",
    Age = 20
};
Console.WriteLine(person);