Console.WriteLine("ВВедите размер массива");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите минимальное значение в  массиве");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите максимальное значение  в массиве");
int max = int.Parse(Console.ReadLine()!);
int[] array = Farray(n, min, max);
PrintArray(array);
FIndSumInPosition(array);
Console.WriteLine(" " + FIndSumInPosition(array));
int FIndSumInPosition(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2!=0)
        {
            sum = sum + array[i];
        }
    }
    return sum;

}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}
int[] Farray(int num, int minimal, int maximal)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minimal, maximal);
    }
    return array;
}
