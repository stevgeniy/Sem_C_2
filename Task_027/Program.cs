int num = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");
int numDigit = GetDigitNum(num);
Console.WriteLine($"{num} -> содержит {numDigit} цифры");


int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int usernamber);
        if (isCorrect && usernamber >= 0)
        {
            return usernamber;
        }  
        Console.WriteLine(errorMessage);

    }
    
}

int GetDigitNum(int num)
{
     int count = 0;
     while (num > 0)
     {
        num = num/10;
        count++;
     }
     return count;
}