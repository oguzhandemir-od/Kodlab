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

    // Write the codes sorting 5 numbers entered from the keyboard in descending order
    // Use arrays
    public static void Question2()
    {
        int[] numbers=new int[5];
        for(int i=0;i<5;i++)
        {
            Console.Write($"{i+1}. sayıyı giriniz: ");
            numbers[i]=int.Parse(Console.ReadLine());
        }
        
        int temp;

        for(int i=0;i<5;i++)
        {
            for(int j=i+1;j<5;j++)
            {
                if(numbers[i]<numbers[j])
                {
                    temp=numbers[i];
                    numbers[i]=numbers[j];
                    numbers[j]=temp;
                }
            }
        }

        for(int i=0;i<5;i++)
        {
            Console.WriteLine($"{i+1}. sayı: {numbers[i]}");
        }
    }
    #endregion
}