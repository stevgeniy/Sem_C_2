Console.Clear();

Console.WriteLine("Введите натуральное число: ");

string text = Console.ReadLine() ?? "";
int length = text.Length;
int[] mas = new int[text.Length];

for (int i = 0; i < length; i++)
{
    mas[i] = int.Parse(text[i].ToString());
}


for (int j = 0; j < length / 2; j++)
{
    if (mas[j] != mas[length - 1 - j])
    {
        Console.WriteLine("НЕ Полиндром");
        break;
    }

}

Console.WriteLine("Полиндром");