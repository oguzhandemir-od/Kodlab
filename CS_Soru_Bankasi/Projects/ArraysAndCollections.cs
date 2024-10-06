class ArraysAndCollections
{
    // Write the codes finding the maximum number among 17 numbers entered on keyboard
    // Use arrays
    #region Arrays - One-Dimensional Arrays
    public static void Question1()
    {
        int[] numbers=new int[17];
        for(int i=0;i<17;i++)
        {
            Console.Write($"{i+1}.sayıyı giriniz: ");
            numbers[i]=int.Parse(Console.ReadLine());            
        }
        int maxNumber=numbers[0];
        for(int i=0;i<17;i++)
        {
            if(numbers[i]>maxNumber)
                maxNumber=numbers[i];
        }

        Console.WriteLine($"En Büyük Sayı: {maxNumber}");
    }
    #endregion
}