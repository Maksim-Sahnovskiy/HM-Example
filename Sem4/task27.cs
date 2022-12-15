Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int sumFromFunction = CalculateSum(number);
Console.WriteLine(sumFromFunction);

int CalculateSum(int lastNumber)
{
    int c = 0;
    int sum = 0;
    while (lastNumber > 0)
    {
        c = lastNumber % 10;
        lastNumber = lastNumber / 10;
        sum = sum + c;
    }
    return sum;
}
