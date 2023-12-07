namespace @delegate;

public class Cat
{
    public Cat(string name)
    {
        Name = name;
    }

    public string Name { get; init; }

    public static void SayMew()
    {
        Console.WriteLine("Mew");
    }
}