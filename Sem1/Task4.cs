Console.WriteLine("Введите число 1 ");
string input = Console.ReadLine()!;
Console.WriteLine("Введите число 2");
string inp = Console.ReadLine()!;
Console.WriteLine("Введите числj 3 ");
string intit = Console.ReadLine()!;
int A = int.Parse(input);
int B = int.Parse(inp);
int C = int.Parse(intit);
int max= A;
if(B>max)
{
    max = B;
}
if (C>max)
{
    max = C;
}
if(A>max)
{
    max = A;
}
Console.WriteLine(max);