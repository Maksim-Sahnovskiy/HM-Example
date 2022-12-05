Console.WriteLine("Введите число ");
string input = Console.ReadLine()!;
Console.WriteLine("Введите число ");
string inp = Console.ReadLine()!;
int A = int.Parse(input);
int B = int.Parse(inp);
if (A > B)
{
    Console.WriteLine("Наибольшее чило " + A);
    Console.WriteLine("Наименьшее число" + B);
}
else if (B > A)
{
    Console.WriteLine("Наибольшее чило " + B);
    Console.WriteLine("Наименьшее число" + A);
}
else
{
    Console.WriteLine("Числа равны");
}
