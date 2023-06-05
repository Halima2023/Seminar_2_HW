//  Task_3 Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//   Даны два неотрицательных числа m и n.
//   m = 2, n = 3 -> A(m,n) = 9
//   m = 3, n = 2 -> A(m,n) = 29
  
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

Console.Write($"Функция Аккермана = {FuncOfAkkerman} ");
Console.Write(FuncOfAkkerman(2, 3));
