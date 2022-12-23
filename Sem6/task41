Console.WriteLine("ВВедите количество чисел");
int quantityNumbers = int.Parse(Console.ReadLine()!);
int[] array = Array(quantityNumbers);
PositiveSum(array);
Console.WriteLine(PositiveSum(array));

int[] Array( int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("введите число");
        int newRequest = int.Parse(Console.ReadLine()!);
        array[i] = newRequest;
    }
    return array;
}

int PositiveSum( int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
        {
            count++;
        }
    }
    return count;
}
