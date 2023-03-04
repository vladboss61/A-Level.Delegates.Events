namespace A_Level.Delegates.Events;

internal static class ClosureExample
{
    public static void MainClosureExample()
    {
        string name = "Den";

        Action action = () =>
        {
            Console.WriteLine("1 MainClosureExample -> " + $" Name: {name}");
            Console.WriteLine("2 MainClosureExample -> " + $" Name: {name}");
            Console.WriteLine("3 MainClosureExample -> " + $" Name: {name}");
        };

        action();

        name = "John";

        action();
    }

    public static void WrongExample()
    {
        var funcs = new List<Func<int>>();

        for (int i = 0; i < 3; i++)
        {
            funcs.Add(() => i);
        }

        foreach (Func<int> func in funcs)
        {
            Console.WriteLine(func());
        }
    }

    public static void GoodExample()
    {
        var funcs = new List<Func<int>>();

        for (int i = 0; i < 3; i++)
        {
            var j = i;
            funcs.Add(() => j);
        }

        foreach (Func<int> func in funcs)
        {
            Console.WriteLine(func());
        }
    }
}
