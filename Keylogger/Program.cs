class Program
{
    static void Main(string[] args)
    {
        Console.Write("Beep!\n");
        Console.Write(">> Press the ESCAPE key to exit!\n");
        Console.Beep();
        var keyInfo = Console.ReadKey(intercept: true);
        if (keyInfo.Key == ConsoleKey.Escape && keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift))
        {
            Console.Beep();
            return;
        }
        while (Console.ReadKey(intercept: true).Key != ConsoleKey.Escape)
        {
            Console.Write(">> Press another key!\n You pressed: " + Console.ReadKey(intercept: true).Key + "\n");
        }
        Console.ReadKey(intercept: true);
        return;
    }
}