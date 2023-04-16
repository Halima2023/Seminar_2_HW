// HW Task_2 Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.


int GetThirdNumber(int num)
{
    while (num > 999)
        num /= 10;
    return num % 10;
}

bool GetDigit(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Tретьей цифры нет");
        return false;
    }
    return true;
}
Console.WriteLine("Input  number, please: ");
int num = Convert.ToInt32(Console.ReadLine());
if (GetDigit(num)) Console.WriteLine(GetThirdNumber(num));


