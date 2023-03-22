int num = GetNumberFromUser("Введите целое число N: ", "Ошибка ввода!");
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"{num} -> {sumNumbers}");



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

int GetSumNumbers (int number)
{
   int sum = 1;
   while (number > 1)
   {
      sum = number*sum;
      number--;
   }

   return sum;


}
