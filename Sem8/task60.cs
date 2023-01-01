// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество глубину массива");
int k = int.Parse(Console.ReadLine());
int[,,] array = new int[n, m, k];
int[] arra = new int[90];
CreateArray(array);
PrintArray(array);
if (n * m * k > 90)
{
    Console.WriteLine("Введите размер массива меньше");
}

int[,,] CreateArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[n,m,k] = new Random().Next(10,100);
            }
        }
    }
}

int[,] Unicum(int[] arr)
{
    for (int i = 0; i < ar.length; i++)
    {
        arr[i] = 
    }
}