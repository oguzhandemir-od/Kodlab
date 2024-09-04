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
    #endregion 
}