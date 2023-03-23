double numA = GetNumberFromUser("Введите число A: ", "Ошибка ввода!");
double numB = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода!");
double degreeNumbers = GetDegreeNumbers(numB, numA);
Console.WriteLine($"{numA}^{numB} -> {degreeNumbers}");



double GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double usernamber);
        if (isCorrect && usernamber >= 0)
        {
            return usernamber;
        }  
        Console.WriteLine(errorMessage);

    }
    
}

double GetDegreeNumbers (double numberB, double numberA)
{
   double sum = numberA;
   while (numberB > 1)
   {
      sum *= numberA;
      numberB--;
   }

   return sum;


}

