class ConstsAndVars
{
    #region Constants
    // As adult ticket prices 10 TL, student ticket prices 7 TL for a theatre; find the total price a family with 3 kids has to pay
    // Prices of tickets must be "constants" in codes
    public static void Question1()
    {
        const int adultTicket=10,studentTicket=7;
        int atNumber,stNumber,total;
        Console.Write("Yetişkin bilet sayısı: ");
        atNumber=int.Parse(Console.ReadLine());
        Console.Write("Öğrenci bilet sayısı: ");
        stNumber=int.Parse(Console.ReadLine());
        total=(atNumber*adultTicket)+(stNumber*studentTicket);
        Console.Write("Toplam tutar: {0} TL",total);
    }
    #endregion

    #region Variable Types
    // Assign values to Short, Sbyte, Int, Decimal, String, Double, Char, Bool and Float variable types
    // Write these values on screen top and bottom
    public static void Question2()
    {
        short shortVar=125;
        sbyte sbyteVar=-25;
        int integerVar=54786;
        decimal decimalVar=123.45m;
        string stringVar="Kitap";
        double doubleVar=456678;
        char charVar='&';
        bool booleanVar=true;
        float floatVar=-2541.78f;
        Console.WriteLine("Short {0}",shortVar);
        Console.WriteLine("SByte {0}",sbyteVar);
        Console.WriteLine("Integer {0}",integerVar);
        Console.WriteLine("Decimal {0}",decimalVar);
        Console.WriteLine("String {0}",stringVar);
        Console.WriteLine("Double {0}",doubleVar);
        Console.WriteLine("Char {0}",charVar);
        Console.WriteLine("Boolean {0}",booleanVar);
        Console.WriteLine("Float {0}",floatVar);
    }
    #endregion
}