// Task_3. Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]          6, 1, 33 -> [6, 1, 33]




int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)

        Console.Write(array[i] + " ");

    Console.WriteLine("]");
}

Console.WriteLine("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);


