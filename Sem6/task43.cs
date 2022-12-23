Console.WriteLine("Введите точку 1 для первой прямой");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите точку 2 для первой прямой");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите точку 1 для второй прямой");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите точку 2 для второй прямой");
int k2 = int.Parse(Console.ReadLine());
double[] arr = IntersectionPoint(b1,b2,k1,k2);
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
double[] IntersectionPoint(double a1,double a2, double h1,double h2)
{
    double[] array = new double[2];
    double x = (a2 - a1) / (h1 - h2);
    double y = h1*x+a1;
    array[0] = x;
    array[1] = y;
    return array;
}