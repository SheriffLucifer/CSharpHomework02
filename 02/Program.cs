Console.WriteLine("Введите любое число: ");
string input = Console.ReadLine() ?? "";

int number = int.Parse(input);

if (number > 99 && number <= 999)
{
    int res = number % 10;
    Console.Write($"{number} -> {res}");
}
else if (number > 999 && number <= 9999)
{
    int res = number / 10 % 10;
    Console.Write($"{number} -> {res}");
}
else if (number > 9999 && number <= 99999)
{
    int res = number / 100 % 10;
    Console.Write($"{number} -> {res}");
}
else
{
    Console.Write($"{number} -> третьей цифры нет");
}