 Console.Write("Введите число : ");

    int num = int.Parse(Console.ReadLine() ?? "");

    for (int i = 1; i < num + 1; i++)
    {
        double result = Math.Pow(i, 3);
        Console.Write($"{result}, ");
    } 
