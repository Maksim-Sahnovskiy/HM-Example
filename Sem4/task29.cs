Console.WriteLine("ВВедите размер массива");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите минимальное значение в  массиве");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите максимальное значение индекса в массиве");
int max = int.Parse(Console.ReadLine()!);
int[] array = Farray(n, min, max);
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
int[] Farray(int nomer, int minimal, int maximal)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minimal, maximal);
    }
    return array;
}

