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
    for (int i = 0; i < array.Length; i++)

        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int GetEvenDidits(int[]myArray)
{ int[] myArray = new int[myArray.Length];
    int evenNum = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] % 2 == 0)
            evenNum = evenNum + 1;
    }
    return evenNum;
}


Console.WriteLine("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myAarray); 

 Console.Write($"Количество чётных чисел в массиве + " ");




