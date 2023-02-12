/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Write("Введите размеры матрицы m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размеры матрицы n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Первая матрица:");
int[,] arr1 = FillArray(m, n);
PrintArray(arr1);
Console.WriteLine("Вторая матрица:");
int[,] arr2 = FillArray(n, m);
PrintArray(arr2);
Console.WriteLine("Произведение двух матриц:");
int[,] arrMulti = MultiplyArray(arr1, arr2);
PrintArray(arrMulti);

int[,] MultiplyArray(int[,] array1, int[,] array2)
{
    int[,] multArray = new int[array1.GetLength(0), array1.GetLength(1)];

    for (int k = 0; k < array1.GetLength(1); k++)
    {
        for (int i = 0; i < multArray.GetLength(1); i++)
        {
            int multNumber = 0;
            for (int j = 0; j < array2.GetLength(0); j++)
            {
                multNumber += array1[k, j] * array2[j, i];
                Console.Write($"{array1[k, j]}*{array2[j, i]} + ");
            }
            Console.Write($"\b\b= {multNumber}    ");
            multArray[k,i] = multNumber;
        }
        Console.WriteLine();
    }
    return multArray;
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
