Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
while (number > 999 || number < -999)
{
    number = number / 10;
}
if (number > 99 && number < 1000)
{
    int third_number = number % 10;
    Console.WriteLine(third_number);
}
if (number < -99 && number > -1000)
{
    int third_number = -(number % 10);
    Console.WriteLine(third_number);
}
if (number < 100 && number > -100)
{
    Console.WriteLine("Нет третьего числа");
}