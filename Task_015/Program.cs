
Console.Clear();
int num = NumberQuadrat("Введите номер четверти;   ");
PrintResult(num);

static int NumberQuadrat(string message)
{
    int n = 0;
    while (true)
    {
        try
        { 
            Console.Write(message);
            n = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception exc)
        {Console.WriteLine("Ошибка ввода");}
    }
    return n;
}

static void PrintResult(int num)
{
    if (num == 1)
        Console.WriteLine("x>0 и y>0");
    else if (num == 2)
        Console.WriteLine("x>0 и y<0");
    else if (num == 3)
        Console.WriteLine("x<0 и y<0");
    else if (num == 4)
        Console.WriteLine("x<0 и y>0");
    else
        Console.WriteLine("Ошибка! Такой четверти не существует");

}