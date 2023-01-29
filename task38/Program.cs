/*
Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
int max = 0;
int min = 0;
int sum = 0;
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(0, 50);
  Console.Write(array[i] + ", ");
}
Console.Write("\b\b");
Console.WriteLine("]");

for (int j = 0; j < array.Length; j++)
{
  while (j < array.Length)
  {
    if (array[j] > array[max]) max = j;
    else if (array[j] < array[min]) min = j;
    else j++;
  }
}
sum = array[max] - array[min];
Console.Write("Разница между максимальным и минимальным элементом: " + sum);
