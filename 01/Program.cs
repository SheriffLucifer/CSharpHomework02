Console.WriteLine("Введите трехзначное число: ");
string input = Console.ReadLine() ?? "";

int number = int.Parse(input);

int res = number / 10 % 10;

Console.Write($"{number} -> {res}");