// Программа которая принимает число и выдаёт все чётные числа до него 
Console.WriteLine("Введите число");
string a = Console.ReadLine()!;
int number = int.Parse(a);
int corrent = 0;
while (corrent<number-1)
{
    corrent = corrent +2;
    Console.WriteLine(corrent);
}

