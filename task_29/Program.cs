// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Будет создан массив длиной A в диапозоне 0-A");
Console.Write("Введите любое число (A): ");

int enterNumber = Convert.ToInt32(Console.ReadLine());
int[] array = new int[enterNumber];

for (int i = 0; i < enterNumber; i++)
{
    array[i] = new Random().Next(enterNumber + 1);
   
}

Console.WriteLine($"[{String.Join(", ", array)}]");
