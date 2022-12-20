Console.WriteLine("ВВедите размер массива");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите минимальное значение в  массиве");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите максимальное значение  в массиве");
int max = int.Parse(Console.ReadLine()!);
double[] array = CreateArray(n, min, max);
PrintArray(array);
DifferenceNumber(array);
Console.WriteLine(" " + DifferenceNumber(array));


double[] CreateArray(int number, int minimal, int maximal)
{
    double[] array = new double[number];
    for (int i = 0; i < array.Length; i++)
    {
        double num = new Random().NextDouble() * (maximal - minimal) + minimal;
        array[i] = Math.Round(num, 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}
double DifferenceNumber(double[] array)
{
    double diference = 0;
    double min = array[1];
    double max = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    diference = Math.Round((max - min),2);
    
    return diference;
}