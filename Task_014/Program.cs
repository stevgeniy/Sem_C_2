Console.Write("Введите число 1: ");

int a1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число 2: ");

int a2= int.Parse(Console.ReadLine() ?? "");

if (a1==a2*a2 || a2==a1*a1)
{
    Console.Write($"{a1},{a2} -> Да ");
}
else
{
    Console.Write($"{a1},{a2} -> Нет ");
}
