Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int count = 1;
while (N >= count)
{
    Console.WriteLine(Math.Pow(count, 3));
    count++;
}
