/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
int sum = 0;
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(0, 8);
  Console.Write(array[i] + ", ");
  if (i % 2 != 0)
  { 
    sum = sum + array[i];
  }
}
Console.Write("\b\b");
Console.WriteLine("]");
Console.Write("Сумма элементов на нечетных позициях: " + sum);
