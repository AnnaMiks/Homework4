// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int InputInt(string message)
{
    Console.WriteLine(message + ">");
    return Convert.ToInt32(Console.ReadLine());
}
int[] GenerateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 99);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item}\t");
    }
    Console.WriteLine();
}
int sizeofArray = InputInt("Введите размер массива");
int[] array = GenerateArray(sizeofArray);
PrintArray(array);