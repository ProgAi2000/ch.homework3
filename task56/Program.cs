/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Write("Введите количество строк массива (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива (n): ");
int n = Convert.ToInt32(Console.ReadLine());

if (m==n) Console.WriteLine("Массив не прямоугольный!");

int[,] arr = FillArray(m, n);
PrintArray(arr);
Console.WriteLine($"Строка с наименьшей суммой элементов: {SumArray(arr)+1}");

int SumArray(int[,] array)
{
    int[,] sumRows = new int[array.GetLength(0),2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        sumRows[i,0] = i;
        sumRows[i,1] = sumRow;
    }
    int minPos = 0;
    for (int i = 0; i < sumRows.GetLength(0); i++)
    {
        if (sumRows[i,1]<sumRows[minPos,1]) minPos=i;
    }
    return minPos;
}

    int[,] FillArray(int row, int col)
    {
        int[,] array = new int[row, col];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
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