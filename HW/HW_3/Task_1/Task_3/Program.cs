// HW_Task_3 Задача 23.Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27    5 -> 1, 8, 27, 64, 125 

void TablCub (int N)
{
    int count = 1;
    while (count <= N)
    {
        Console.WriteLine ($"Куб числа {count}  составляет - { count*count*count} ");
        count++;
    }
}
Console.Write ("Введите значение  - ");
int num = Convert.ToInt32(Console.ReadLine()); 
TablCub (num);
