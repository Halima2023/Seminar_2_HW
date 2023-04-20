// HW_Task_1. Задача 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом. 14212 -> нет, 12821 -> да, 23432 -> да
/*
void GetDigitNumber(int num)
{
    int num1 = num %  10 * 10000 + num / 10 % 10* 1000 + num / 100 % 10 * 100 + num / 1000 % 10 * 10 + num / 10000;
    if (num == num1) Console.WriteLine("Yes!");
    else Console.WriteLine("No!");
}
Console.Write("Please, enter  number ");
int num = Convert.ToInt32(Console.ReadLine());
GetDigitNumber(num);
////////////////////////////////////////////////////////////////
*/
void AnyNumber(int num)
{
    int palindrom = num;
    int rev = 0;
    while (num > 0)
    {
        rev = rev * 10 + num % 10;
        num = num / 10;
    }
    if (palindrom == rev) Console.WriteLine("Yes!");
    else Console.WriteLine("No!");

}
Console.Write("Please, enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
AnyNumber(num);