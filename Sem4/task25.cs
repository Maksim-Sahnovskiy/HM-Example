Console.WriteLine("введите чисо A");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите чисо B");
int B = int.Parse(Console.ReadLine()!);
int cvadrat = Function(A, B);
Console.WriteLine(cvadrat);
int Function(int A, int B)
{
    int C = A;
    for (int i = 2; i <= B; i++)
    {
        A = A * C;
    }
    return A;
}