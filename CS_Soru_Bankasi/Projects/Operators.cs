class Operators
{
    #region Arithmetic Operators
    // Write the codes computing sum, subtraction, multiplication, division and mode of two numbers entered by user
    public static void Question1()
    {
        Console.Write("Bir sayı giriniz: ");
        int number1=int.Parse(Console.ReadLine());
        Console.Write("Bir sayı giriniz: ");
        int number2=int.Parse(Console.ReadLine());
        int sum=number1+number2;
        Console.WriteLine("{0} + {1} = {2}",number1,number2,sum);
        int subtraction=number1-number2;
        Console.WriteLine("{0} - {1} = {2}",number1,number2,subtraction);
        int multiplication=number1*number2;
        Console.WriteLine("{0} x {1} = {2}",number1,number2,multiplication);
        double division=(double)number1/(double)number2;
        Console.WriteLine("{0} / {1} = {2}",number1,number2,division);
        int mode=number1%number2;
        Console.WriteLine("{0} % {1} = {2} ",number1,number2,mode);
    }

    // Write the codes computing the average of four numbers entered by user
    public static void Question2()
    {
        Console.Write("1. sayıyı giriniz: ");
        int number1=int.Parse(Console.ReadLine());
        Console.Write("2. sayıyı giriniz: ");
        int number2=int.Parse(Console.ReadLine());
        Console.Write("3. sayıyı giriniz: ");
        int number3=int.Parse(Console.ReadLine());
        Console.Write("4. sayıyı giriniz: ");
        int number4=int.Parse(Console.ReadLine());
        double average=((double)(number1+number2+number3+number4)/4);
        Console.Write("({0} + {1} + {2} + {3}) / 4 = {4}",number1,number2,number3,number4,average);
    }
    #endregion 
}