// Task_1. Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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


void OrderOfNum2dArray(int[,] array, int m, int n)
{
    int[,] arr = new int[m, n];
 
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(0); k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
}
    int[,] myArray = CreateRandom2dArray();
    Show2dArray(myArray);
    OrderOfNum2dArray(myArray, myArray.GetLength(0), myArray.GetLength(1));
    Show2dArray(myArray);

