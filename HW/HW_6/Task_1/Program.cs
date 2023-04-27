//HW_6 Task_1. Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2    1, -7, 567, 89, 223-> 3

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
       

    return array;
}

void ShowArray(int[] array)

{



    int[] myArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)

        Console.Write(array[i] +" "); 
      
}

int QuantityOfPositiv(int[] array)
{
    int[] myArray = new int[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
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
QuantityOfPositiv(myArray);
int res = QuantityOfPositiv(myArray);
Console.Write($"Количество чисел больше нуля -> {res}");




