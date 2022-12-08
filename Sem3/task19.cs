Console.WriteLine("Введите пятизначное число ");
int fiveNumber = int.Parse(Console.ReadLine()!);
int secondNumber = fiveNumber % 1000;
int firstNumber = 0;
while (fiveNumber > 999)
{
    fiveNumber = fiveNumber / 10;
    firstNumber = fiveNumber;

}
if (secondNumber % 10 == firstNumber / 100 && secondNumber / 10 % 10 == firstNumber / 10 % 10 && secondNumber / 100 == firstNumber % 10)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}