// Task_2. Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

        int SumOfDigits (int num1, int num2)
        {
            int m = num1;
            int n = num2;
            if (m > 0)  return ((m + n)*(n - m + 1) / 2);
            return 0;
        }
        Console.WriteLine(SumOfDigits(4, 8));