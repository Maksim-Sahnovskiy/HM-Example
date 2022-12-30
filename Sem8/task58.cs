Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, m];
int[,] secondmatrix = new int[n, m];
Newmatrix(matrix,secondmatrix);
FillmatrixRandom(matrix);
Printmatrix2D(matrix);
Console.WriteLine();
FillmatrixRandom(secondmatrix);
Printmatrix2D(secondmatrix);
Console.WriteLine();
Printmatrix2D(Newmatrix(matrix,secondmatrix));

int[,] Newmatrix(int[,] a, int[,] b)
{ 
    int [,] resultmatrix = new int[matrix.GetLength(0),matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondmatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                resultmatrix[i, j] += matrix[i, k] * secondmatrix[k, j];
            }
        }
    }
    return resultmatrix;
}



void FillmatrixRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void Printmatrix2D(int[,] matrix)
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
