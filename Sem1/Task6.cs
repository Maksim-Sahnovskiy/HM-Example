Console.WriteLine("Введите число ");
string A = Console.ReadLine()!;
int number = int.Parse(A);
if (number%2>0)
{
    Console.WriteLine("Нечётное число");
}
else
{
    Console.WriteLine("Чётное число");
}