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
}