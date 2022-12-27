Console.WriteLine("Введите значение m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение в массиве");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение в массиве");
int max = int.Parse(Console.ReadLine()!);

double[,] matrix = CreateArray2DRealNumbers(m, n, min, max);
PrintArray(matrix);

double[,] CreateArray2DRealNumbers(int m, int n, int minimal, int maximal)
{
    double[,] newmatrix = new double[m, n];
    for (int i = 0; i < newmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newmatrix.GetLength(1); j++)

            newmatrix[i, j] = Math.Round((maximal - minimal) * new Random().NextDouble() + minimal, 2);
    }
    return newmatrix;
}


void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
