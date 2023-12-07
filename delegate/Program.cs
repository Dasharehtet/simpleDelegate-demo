namespace @delegate;

public abstract class Program
{
    public static void Main()
    {
        Action<int, string, bool> action = SomeMethod;
        action += (x, _, _) => Console.WriteLine(x);
        action(10, "text", true);

        Func<string, bool, int> func = SomeMethod;
        //  func += () => 45;
        Console.WriteLine(func("Test", true));

        Func<int, int, int> func2 = (x, y) => x + y;

        Console.WriteLine(func2(2, 4));

        Action<Cat> catAction = cat => Cat.SayMew();
        var cat = new Cat("New cat");

        catAction(cat);

        Func<Cat, string> catFunc = cat => cat.Name;
        Console.WriteLine(catFunc(cat));
    }

    private static int SomeMethod(string text, bool someBool)
    {
        Console.WriteLine(text);
        return 42; 
    }

    private static void SomeMethod(int number, string text, bool someBool)
    {
        Console.WriteLine($"{number}, {text}, {someBool}");
    }
}