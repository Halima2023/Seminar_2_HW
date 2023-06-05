// Task_1. Задайте значение N Выведите все натуральные числа
/*
void ShowNums(int num)
{
    if (num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}
ShowNums(5);

Task_2.

int SumOfDigits(int num)
{
    if(num != 0) return SumOfDigits(num / 10) + num % 10;
    return 0;
}
Console.WriteLine(SumOfDigits(1234));

f(1234) -> f(123) + 4 
f(123) -> f(12) + 3 
f(12) -> f(1) + 2 
f(1) -> f(0) + 1
f(0) -> 0
f(1) -> 0 + 1 = 1
f(12) -> 1 + 2 = 3
f(123) -> 3 + 3 = 6
f(1234) -> 6 + 4 = 10

// Task_3. Задайте значение M и N. Напишите программу, которая выведeт все натуральные числа 
// в промежутке от M до N.
void ShowNums2(int m, int n)
{
    if (n > m)
    {
        ShowNums2(m, n - 1);
        Console.Write(n + " ");
    }
    if (n < m)
    {
        ShowNums2(m, n + 1);
        Console.Write(n + " ");
    }
    if (m == n)
    {
        Console.Write(m + " ");
    }
}
ShowNums2(5,1);
*/
void ShowNums2(int n, int m)
{
     Console.Write(n + " ");
    if (n > m) ShowNums2(n - 1, m);
    if (n < m) ShowNums2(n + 1, m);
}
ShowNums2(5, 2);


/*
Task_4. Напишите программу, которая на вход принимает два числа А и В, и
возводит число А в целую степень В.


int MultiplyNums(int a, int b)
{
    if (b != 0) return MultiplyNums(a, b - 1) * a;
    return 1;
}

Console.WriteLine(MultiplyNums(3,2));
*/