// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел для ввода: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] arr = FillArray(M);

int[] FillArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArr(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
    {
      Console.Write($"{arr[i]} ");
    }
}

int CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) count++;
    }
    return count;
}
Console.Write("[");
PrintArr(arr);
Console.Write("\b]");
Console.Write($" ->   из них положительных {CountNumber(arr)}");