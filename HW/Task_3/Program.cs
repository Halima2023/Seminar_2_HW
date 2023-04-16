//HW Task_3. Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую
//  день недели, и проверяет, является ли этот день выходным. 6 -> да, 7 -> да, 7 -> да


Console.WriteLine("Input  number, please:");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
if (dayOfWeek == 6 || dayOfWeek == 7) Console.WriteLine("Yes!");
else if (dayOfWeek <= 5) Console.WriteLine("No!");
else if (dayOfWeek > 7) Console.WriteLine("It is not a day of the week.");

