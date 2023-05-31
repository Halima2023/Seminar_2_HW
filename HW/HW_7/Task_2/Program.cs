// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет. 
/*
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1 7 -> числа с такими индексами в массиве нет

Console.Write("Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine());
int n = 6; 
int m = 9; 
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = random.Next(100);
Console.Write("{0} ", arr[i, j]);
}
Console.WriteLine();
}
    if (pos1 < 0 | pos1 > arr.GetLength(0)
 | pos2 < 0 | pos2 > arr.GetLength(1))
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
}
Console.ReadLine();
 */

int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void NumPosition(int[,] arr, int pos1, int pos2)
{
    if (pos1 < arr.GetLength(0) && pos1 >= 0 &&
        pos2 < arr.GetLength(1) && pos2 >= 0)
        Console.WriteLine(arr[pos1, pos2]);
    else
        Console.WriteLine("Element doesn't exist!");
}

Console.Write("Input  pos1: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input pos2 : ");
int pos2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
NumPosition ( myArray ,pos1, pos2);






