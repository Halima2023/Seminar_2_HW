// HW_2 Task_1 Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.


int ThirdNumber(int num)
{
    int dozent = num / 10;
    int units = num % 10;
    int result = num / 10 % 10;
    return result;
}

Console.WriteLine("Input  number, please: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = ThirdNumber(num);
Console.WriteLine(result);