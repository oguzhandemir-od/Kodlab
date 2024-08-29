class ConsoleApps
{
    #region Write and WriteLine Methods
    // Using Write method, write "Merhaba, C# Kullanıcıları" on screen
    public static void Question1()
    {
        Console.Write("Merhaba, C# Kullanıcıları");
    }

    // Using WriteLine method, write "Merhaba, C# Kullanıcıları" on screen
    public static void Question2()
    {
        Console.WriteLine("Merhaba, C# Kullanıcıları");
    }

    // Using Write method, write this output on screen: A=50B=25
    public static void Question3()
    {
        int a=50,b=25;
        Console.Write("A={0}",a);
        Console.Write("B={0}",b);
    }

    // Using WriteLine method, write this output on screen: A=50
    // B=25
    public static void Question4()
    {
        int a=50,b=25;
        Console.WriteLine("A={0}",a);
        Console.WriteLine("B={0}",b);
    }
    #endregion
}