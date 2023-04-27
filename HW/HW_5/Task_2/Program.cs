// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях. [3, 7, 23, 12] -> 19      [-4, -6, 89, 6] -> 0


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    Console.Write($"New array: [{array[0]}");

    for (int i = 1; i < array.Length; i++)

        Console.Write($" {array[i]}");
    Console.Write("]");
}

int GetSumOfOddesDig(int[] array)
{
    int odd = 0;
    for (int i = 1; i < array.Length; i = i + 2)
        odd += array[i];
    return odd;
}

Console.WriteLine("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int odd = GetSumOfOddesDig(myArray);
Console.Write($" Sum of odd indeks -> {odd} ");
