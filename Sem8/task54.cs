
Console.WriteLine("Введите значение m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение в массиве");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение в массиве");
int max = int.Parse(Console.ReadLine()!);
int[,] matrix = Creatematrix(n, m, min, max);
Printmatrix(matrix);
Console.WriteLine();
NewMatrix(matrix);
PrintNewmatrix(matrix);


int[,] Creatematrix(int m, int n, int min, int max)
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

void Printmatrix(int[,] matrix)
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

int[,] NewMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(1) - 1; n++)
            {
                if (matrix[i, n] < matrix[i, n+ 1])
                {
                    int temp = matrix[i, n + 1];
                    matrix[i, n + 1] = matrix[i, n];
                    matrix[i, n] = temp;
                }
            }
        }
    }
    return matrix;
}

void PrintNewmatrix(int[,] smatrix)
{
    for (int i = 0; i < smatrix.GetLength(0); i++)
    {
        for (int j = 0; j < smatrix.GetLength(1); j++)
        {
            Console.Write($"{smatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}