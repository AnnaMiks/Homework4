// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать Math.Pow
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Prompt(string message)
{
    Console.WriteLine(message + ">");
    return Convert.ToInt32(Console.ReadLine());
}
int a = Prompt("Введите число А");
int b = Prompt("Введите число B");
int result = a;
for(int i=1; i<b; i++){
    result=result*a;
}
    
Console.WriteLine($"Число A в степени В равна {result}");