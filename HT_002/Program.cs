while (true)
{
    Console.Write("Введите число : ");

    int num = int.Parse(Console.ReadLine() ?? "");

    if (num >= 100)
    {
        Console.WriteLine($"Вы ввели '{num}' ");
        
        while (num > 999)
        {
            num /= 10;
        }
        int Num_3 = num % 10;
        Console.WriteLine($"Третья цифра числа '{Num_3}' ");
        break;
    }
    else
    {
        Console.WriteLine($"{num} не имеет третьей цифры, попробуйте еще раз");
    }


}
