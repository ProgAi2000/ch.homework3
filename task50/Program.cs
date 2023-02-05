// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк массива (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива (n): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс строки элемнта: ");
int indexm = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца элемента: ");
int indexn = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int [m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = new Random().Next(1,10);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine();
    }
}

PrintArray(arr);

if (indexm >= arr.GetLength(0) || indexn >= arr.GetLength(1)) Console.WriteLine($" {indexm}; {indexn} -> Такого элемента в массиве нет! ");
else Console.Write(indexm + ", " + indexn + " -> " + arr[indexm,indexn]);