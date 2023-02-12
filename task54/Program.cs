/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Write("Введите количество строк массива (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива (n): ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = FillArray(m, n);
PrintArray(arr);
Console.WriteLine();
int[,] sortArr = SortArray(arr);
PrintArray(sortArr);

int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, max]) max = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, max];
            array[i, max] = temp;
        }
    }
    return array;
}

int[,] FillArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;
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