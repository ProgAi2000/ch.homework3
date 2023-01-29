/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sumNumbers = 0;
while (num != 0)
{
  sumNumbers = sumNumbers + num % 10;
  num /= 10;
}

Console.WriteLine("Сумма цифр -> " + sumNumbers);

