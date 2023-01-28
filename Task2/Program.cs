// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int Prompt(string message)
{
    Console.WriteLine(message + ">");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");
int SumDigits(int value)
{
    int result = 0;

    while (value > 0)
    {
        result = result +value % 10;
        value = value / 10;
    }
    return result;
}
int result = SumDigits(number);
Console.WriteLine($"Сумма цифр числа равна {result}");