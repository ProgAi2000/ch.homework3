// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
Console.WriteLine("Введите пятизначное число:");
string num = Convert.ToString(Console.ReadLine());
int length = num.Length;
if (length == 5) 
{
 string num5 = num.Substring(4, 1);
 string num4 = num.Substring(3, 1);
 string num2 = num.Substring(1, 1);
 string num1 = num.Substring(0, 1);
  if (num5 == num1 && num4 == num2) Console.Write("Число - палиндром ");
  else Console.Write("Число не палиндром");
}
else Console.Write ("Число не пятизначное");
*/
using System;
Console.WriteLine ("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int num5 = num % 10;
int num4 = num / 10 % 10;
int num2 = num / 1000 % 10;
int num1 = num / 10000;
if (num < 100000 && num >= 10000)
{
  if (num5 == num1 && num4 == num2) Console.Write("Число - палиндром");
  else Console.Write("Число не палиндром");
} 
else Console.Write ("Число не пятизначное ");
