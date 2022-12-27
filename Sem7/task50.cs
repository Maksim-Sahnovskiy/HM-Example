Console.WriteLine("Введите значение m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение в массиве");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение в массиве");
int max = int.Parse(Console.ReadLine()!);

int[,] matrix = CreateArray2DRealNumbers(m, n, min, max);
PrintArray(matrix);
Position(matrix);

int[,] CreateArray2DRealNumbers(int m, int n, int minimal, int maximal)
{
    int[,] newmatrix = new int[m, n];
    for (int i = 0; i < newmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newmatrix.GetLength(1); j++)

            newmatrix[i, j] = new Random().Next(minimal, maximal);
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
void Position(int[,] matrix)
{
    Console.WriteLine("Введите позицию m");
    int column = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите позицию n");
    int line = int.Parse(Console.ReadLine());
    int j = 0;

    if (column > matrix.GetLength(1) || line > matrix.GetLength(0))
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else

    {
        j = matrix[column, line];
        Console.WriteLine(j);
    }
}