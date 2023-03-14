Console.Write("Введите число 1: ");

int Num1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число 2: ");

int Numb2= int.Parse(Console.ReadLine() ?? "");

if (Num1 % Numb2 == 0)
{
    Console.Write($"{Num1} Кратно: {Numb2}");
}
else
{
    Console.Write($"{Num1} не кратно: {Numb2}");
}
