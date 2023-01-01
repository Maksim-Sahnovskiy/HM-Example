Console.Write("Введите число");
int number = int.Parse(Console.ReadLine());
int count = 1;
NaturalToLow(number, count);


void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + " ");
    }
}