/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите чило N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write(SumOfNumbers(N,M));

int SumOfNumbers(int start, int end)
{   int sum = 0;
    if (start == end + 1 ) return sum;
    return (sum = start + SumOfNumbers(start+1,end));
}