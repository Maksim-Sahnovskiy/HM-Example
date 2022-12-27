Console.WriteLine("Введите значение m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение в массиве");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение в массиве");
int max = int.Parse(Console.ReadLine()!);
int[,] matrix = CreateArray(n, m, min, max);
PrintArray(matrix);
ColumnAverage(matrix);
PrintArr(ColumnAverage(matrix));

int[,] CreateArray(int n, int m, int minimal, int maximal)
{
    int[,] newmatrix = new int[m, n];
    for (int i = 0; i < newmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newmatrix.GetLength(1); j++)
        {
            newmatrix[i, j] = new Random().Next(minimal, maximal);
        }
    }
    return newmatrix;
}

void PrintArray(int[,] matrix)
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

double[] ColumnAverage(int[,] matrix)
{
    int columnCount = matrix.GetLength(1);
    int rowCount = matrix.GetLength(0);
    double[] result = new double[columnCount];
    for (int j = 0; j < columnCount; j++)
    {
        int sum = 0;
        for (int i = 0; i < rowCount; i++)
        {
            sum = sum + matrix[i, j];
        }
        result[j] = (double)sum / rowCount;
    }
    return result;
}
void PrintArr(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
}