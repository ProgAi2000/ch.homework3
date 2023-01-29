/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.Write("Минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[8];
Console.Write("[");
for (int i = 0; i < 8; i++)
{
  arr[i] = new Random().Next(min,max);
  Console.Write(arr[i] + ", ");
}
Console.Write("\b\b");
Console.Write("]");