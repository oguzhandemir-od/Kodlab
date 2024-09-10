class ControlStructes
{
    #region If Structure
    // Write the codes finding if the entered number is 10 or less than 10 or greater than 10 using if command
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

    // Write the codes finding whether the input value is a letter or a number or a special character using if command
    public static void Question2()
    {
        Console.Write("Bir tuşa basınız: ");
        char input=Convert.ToChar(Console.ReadLine());

        if((input>='a'&&input<='z')||(input>='A'&&input<='Z'))
        {
            Console.WriteLine("Bir harfe basıldı.");
        }
        if(input>='0'&&input<='9')
        {
            Console.WriteLine("Bir rakama basıldı.");
        }
        if(!((input>='a'&&input<='z')||(input>='A'&&input<='Z')
        ||(input>='0'&&input<='9')))
        {
            Console.WriteLine("Özel karaktere basıldı.");
        }
    }
    #endregion
}