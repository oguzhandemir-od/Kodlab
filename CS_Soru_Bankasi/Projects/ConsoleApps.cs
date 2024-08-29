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

    #region Read and ReadLine Methods
    // Find the sum and average of the numbers entered by user
    public static void Question5()
    {
        int number1, number2,number3,number4,total,average;
        Console.Write("1. sayıyı giriniz: ");
        number1=int.Parse(Console.ReadLine());
        Console.Write("2. sayıyı giriniz: ");
        number2=int.Parse(Console.ReadLine());
        Console.Write("3. sayıyı giriniz: ");
        number3=int.Parse(Console.ReadLine());
        Console.Write("4. sayıyı giriniz: ");
        number4=int.Parse(Console.ReadLine());
        total=number1+number2+number3+number4;
        average=total/4;
        Console.WriteLine("Sayıların toplamı: {0}",total);
        Console.WriteLine("Sayıların ortalaması: {0}",average);
    }

    // Using Read method, find the ASCII code of keyboard entry
    public static void Question6()
    {
        int code;
        Console.Write("Bir tuşa basınız: ");
        code=Console.Read();
        Console.WriteLine("Bastığınız tuşun ASCII karşılığı: {0}",code);
    }
    #endregion
}