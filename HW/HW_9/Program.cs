// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNums3(int num)
{
     Console.Write(num + ", ");
    if (num > 1) ShowNums3(num - 1);
}
ShowNums3(8);

//Task_2. Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30


        int SumOfDigits (int num1, int num2)
        {
            int m = num1;
            int n = num2;
            if (m > 0)  return ((m + n)*(n - m + 1) / 2);
            return 0;
        }

    Console.WriteLine(SumOfDigits(1, 15));
   
   Task_3 Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
   Даны два неотрицательных числа m и n.
   m = 2, n = 3 -> A(m,n) = 9
   m = 3, n = 2 -> A(m,n) = 29
   */
  
int FuncOfAkkerman(int m, int n)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return FuncOfAkkerman(n - 1, 1);
    else
      return FuncOfAkkerman(n - 1, FuncOfAkkerman(n, m - 1));
}
Console.Write(FuncOfAkkerman(2, 3));