Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);

int[] array = Array(size);
PrintArray(array);
EvenNumber(array);
Console.WriteLine(EvenNumber(array));

int[] Array(int sizze)
{
    int[] array = new int[sizze];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
int EvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}


