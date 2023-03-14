Console.Write("Введите целое число : ");

int Num = int.Parse(Console.ReadLine() ?? "");

if (Num % 7 == 0 && Num % 23 == 0)
{
    Console.Write($"{Num} Кратно 7 и 23");
}
else
{
    Console.Write($"{Num} не кратно 7 и 23");
}
