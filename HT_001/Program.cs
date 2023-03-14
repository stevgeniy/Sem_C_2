Console.Write("Введите трехзначное число : ");

int num = int.Parse(Console.ReadLine() ?? "");

if (num < 100 || num >= 1000)
{
    Console.WriteLine($"{num} не является трёхзначным, попробуйте еще раз");
    //return;
}
else
{
    Console.WriteLine($"Вы ввели '{num}' ");
    int SecondNum = num / 10 % 10;
    Console.WriteLine($"Вторая цифра числа '{SecondNum}' ");
}
