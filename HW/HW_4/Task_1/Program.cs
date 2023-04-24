//HW_Task  25: Напишите цикл, который принимает на вход два числа (A и B) и
//возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵), 2, 4 -> 16

void GetNumbers(int num1, int num2)
{
    double pow = 0;
    pow = Math.Pow(num1, num2); 
}
Console.Write ("Введите значение num1 - ");
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write ("Введите значение num2 - ");
int num2 = Convert.ToInt32(Console.ReadLine()); 
double result =  Math.Pow(num1, num2);
Console.Write ($"Число в натуральной степени  - {result}");
