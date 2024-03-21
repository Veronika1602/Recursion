// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.тИспользовать рекурсию, не
// использовать циклы.

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        void OutputOfNumbers(int m, int n)
        {
            if (m > n)
                return;
            {
                Console.Write($"{m}, ");
            }
            OutputOfNumbers(m + 1, n);
        }
        OutputOfNumbers(m, n);
    }
}