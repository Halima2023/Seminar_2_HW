﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11  82 -> 10  9012 -> 12


int SumNumber(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}
Console.WriteLine("Input  number, please: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = SumNumber(num);
Console.WriteLine($"Sum of all digits in numbers = {sum} ");

