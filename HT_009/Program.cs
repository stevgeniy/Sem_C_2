int num = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");
int sumNumDigit = GetSumDigitNum(num);
Console.WriteLine($"{num} -> сумма цифр {sumNumDigit}");


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

int GetSumDigitNum(int num)
{
     int count = 0;
     while (num > 0)
     {
        count += num % 10;
        num = num/10;        
     }
     return count;
}
