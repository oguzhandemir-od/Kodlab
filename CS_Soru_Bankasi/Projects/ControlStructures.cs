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

    // Write the codes finding the minimum number between the three numbers entered by user, using if command
    public static void Question3()
    {
        int minNumber,newNumber;
        Console.Write("Bir sayı giriniz: ");
        minNumber=int.Parse(Console.ReadLine());
        Console.Write("Bir sayı giriniz: ");
        newNumber=int.Parse(Console.ReadLine());
        if(newNumber<minNumber)
        {
            minNumber=newNumber;
        }
        Console.Write("Bir sayı giriniz: ");
        newNumber=int.Parse(Console.ReadLine());
        if(newNumber<minNumber)
        {
            minNumber=newNumber;
        }
        Console.WriteLine($"Girilen en küçük sayı: {minNumber}");
    }

    // Write the codes finding whether the pressed key is lower case or UPPER CASE with if-else commands
    public static void Question4()
    {
        Console.Write("Bir harf tuşuna basınız: ");
        char letter=Convert.ToChar(Console.ReadLine());
        if(letter>='a'&&letter<='z')
        {
            Console.WriteLine("küçük harf");
        }
        else
        {
            Console.WriteLine("BÜYÜK HARF");
        }
    }

    // Write the codes finding whether the number entered is odd or even, using if command
    public static void Question5()
    {
        Console.Write("Bir sayı giriniz: ");
        int number=int.Parse(Console.ReadLine());
        if((number%2)==0)
        {
            Console.WriteLine("Girilen sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Girilen sayı tektir.");
        }
    }

    // Write the codes computing the roots of a quadratic equation using if-else command
    public static void Question6()
    {
        Console.WriteLine("ax2 + bx + c denklemi için,");
        Console.Write("a katsayısını giriniz: ");
        int aFactor=int.Parse(Console.ReadLine());
        Console.Write("b katsayısını giriniz: ");
        int bFactor=int.Parse(Console.ReadLine());
        Console.Write("c sayısını giriniz: ");
        int cFactor=int.Parse(Console.ReadLine());

        double delta=(bFactor*bFactor)-(4*aFactor*cFactor);
        if(delta>0)
        {
            double rootOne=(-bFactor+Math.Sqrt(delta))/(2*aFactor);
            double rootTwo=(-bFactor-Math.Sqrt(delta))/(2*aFactor);
            Console.WriteLine($"1. Kök: {rootOne}");
            Console.WriteLine($"2. Kök: {rootTwo}");
        }
        else if(delta==0)
        {
            double rootOnly=-bFactor/(2*aFactor);
            Console.WriteLine($"Tek Kök: {rootOnly}");
        }
        else
        {
            Console.WriteLine("Reel kök yoktur");
        }
    }

    // Write the program codes approving the applications of the applicants who are men, done the military service
    // And equal or less than 30, after receive the gender, military service and age information,
    // Using if-else command
    public static void Question7()
    {
        Console.WriteLine("Başvuran kişinin cinsiyeti");
        Console.Write("Erkek için (e), bayan için (b): ");
        char applicantGender=Convert.ToChar(Console.ReadLine());
        if(applicantGender=='b')
        {
            Console.WriteLine("Yalnızca erkek personel işe alınacaktır.");
        }
        else if(applicantGender=='e')
        {
            Console.WriteLine("Askerlik durumunu giriniz");
            Console.Write("Yapıldı ise (e), yapılmadı ise (h): ");
            char serviceDone=Convert.ToChar(Console.ReadLine());
            if(serviceDone=='h')
            {
                Console.WriteLine("Askerliğini yapmış personel işe alınacaktır.");
            }
            else if(serviceDone=='e')
            {
                Console.Write("Yaşınız: ");
                int age=int.Parse(Console.ReadLine());
                if(age<=30)
                {
                    Console.WriteLine("İşe alındınız");
                }
                else
                    Console.WriteLine("Yaşınız 30 veya daha küçük olmalıdır.");
            }
        }
    }
    #endregion
}