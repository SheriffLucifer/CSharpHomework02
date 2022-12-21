Console.WriteLine("Введите день недели в виде числа от 1 до 7: ");
string input = Console.ReadLine() ?? "";

int number = int.Parse(input);

if (number >= 1 && number <= 5)
{
    Console.Write($"{number} -> нет");
}
else
{
    Console.Write($"{number} -> да");
}