while (true)
{
    Console.Write("Введите номер дня : ");

    int day = int.Parse(Console.ReadLine() ?? "");

    if (day > 0 && day <= 7)
    {
        if (day > 5)
        {
            Console.WriteLine("Выходной день, УРА!");
        }
        else
        {
            Console.WriteLine("Все на работу!");
        }
        break;
    }
    else
    {
        Console.WriteLine("Такого дня еще не придумали, попробуйте еще раз");
    }

}
