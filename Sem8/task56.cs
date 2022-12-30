int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение в массиве");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение в массиве");
int max = int.Parse(Console.ReadLine()!);
int[,] matrix = CreateArray(n, m, min, max);
PrintArray(matrix);
MinSumRow(matrix);



int[,] CreateArray(int m, int n, int min, int max)
{
    int[,] newmatrix = new int[m, n];
    for (int i = 0; i < newmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newmatrix.GetLength(1); j++)
        {
            newmatrix[i, j] = new Random().Next(min, max);
        }
    }
    return newmatrix;

}

void PrintArray(int[,] twomatrix)
{
    for (int i = 0; i < twomatrix.GetLength(0); i++)
    {
        for (int j = 0; j < twomatrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

}

void MinSumRow(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

