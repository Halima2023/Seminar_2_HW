// HW_5_Task_1 Задача 34: Задайте массив заполненный случайными положительными трёхзначными  числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2
/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(99, 999);

    return array;
}

void ShowArray(int[] array)

{

    Console.Write("[");

    int[] myArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)

        Console.Write(array[i] + " "); 
        Console.Write("]");
}

int QuantityOfEven(int[] array)
{
    int[] myArray = new int[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimum possible element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximum possible element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
QuantityOfEven(myArray);
int res = QuantityOfEven(myArray);
Console.Write($" Количество четных элементов в массиве -> {res}");

*/


// HW_5_Task_1 Задача 34: Задайте массив заполненный случайными положительными трёхзначными  числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(99, 999);

    return array;
}

void ShowArray(int[] array)

{

    Console.Write($"New array: [{array[0]}");

    for (int i = 0; i < array.Length; i++)

        Console.Write($" {array[i]}"); 
        Console.Write("]");
}

int QuantityOfEven(int[] array)
{
    int[] myArray = new int[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimum possible element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximum possible element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
QuantityOfEven(myArray);
int res = QuantityOfEven(myArray);
Console.Write($" Количество четных элементов в массиве -> {res}");


