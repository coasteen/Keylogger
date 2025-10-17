class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Beep!\n");
        Console.Write(">> Press the ESCAPE key to exit!\n");
        Console.Beep();

        while (Console.ReadKey(intercept: true).Key != ConsoleKey.Escape)
        {
            Console.Write(">> Press another key!\n You pressed: " + Console.ReadKey(intercept: true).Key + "\n");

            if ((Console.ReadKey(intercept: true).Modifiers & ConsoleModifiers.Shift) != 0)
            {
                Console.Write(">> Press another key!\n You pressed: Left Shift");
            }

            if (Console.ReadKey(intercept: true).Key == ConsoleKey.P)
            {
                Console.Beep();
            }
        }
        
        Console.ReadKey(intercept: true);
        return;
    }
}
