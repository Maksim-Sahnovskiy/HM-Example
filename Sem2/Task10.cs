Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine()!);
int first_number = number / 100;
int third_number = number % 10;
int second_number = (number - (first_number * 100) - third_number) / 10;

Console.WriteLine(second_number);