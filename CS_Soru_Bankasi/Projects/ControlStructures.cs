class ControlStructes
{
    #region If Structure
    public static void Question1()
    {
        Console.Write("Bir sayı giriniz: ");
        int number=int.Parse(Console.ReadLine());
        if(number<10)
        {
            Console.WriteLine("10'dan küçük bir sayı girildi");
        }
        else if(number==10)
        {
            Console.WriteLine("10 sayısı girildi");
        }
        else
        {
            Console.WriteLine("10'dan büyük bir sayı girildi");
        }
    }
    #endregion
}