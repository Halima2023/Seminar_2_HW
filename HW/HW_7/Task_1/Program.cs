﻿// Task_1 Задача 47. Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами. m = 3, n = 4.  0,5 7 -2 -0,2
// 1 -3,3 8 -9,9   8 7,8 -7,1 9

double[,] GreateRandom2dArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(-99, 99) / 10.0;
           

    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Input a quantity of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = GreateRandom2dArray(m, n);
Show2dArray(myArray);
