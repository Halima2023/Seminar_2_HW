// Двумерный массив


Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = GreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
*/
//Task_1 Необходимо задать двумерный массив  размером m на n,
// каждый элемент в массиве находится по формуле: Aij = i + j.
// Выведите полученный массив на экран.
/*
int[,] GreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = i + j;
            
    return array;   
}


Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] myArray = GreateArray(rows, columns);
Show2dArray(myArray);



// Task_2 Задайте двумерный массив. Найдите элементы, у которых оба индекса четные,
// и замените эти элементы на их квадраты.

void SquarArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i+=2)
        for (int j = 0; j < array.GetLength(1); j+=2)
            array[i,j] *= array[i,j];            
}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = GreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
SquarArray(myArray);
Show2dArray(myArray);


// Task_3  Задайте двумерный массив. Найдите сумму элементов, находящихся на 
// главной диоганали (с индексами (0,0); (1; 1) и т. д.)*/

int DiagSum (int [,] array)
{
    int sum = array [0,0];
    for(int i = 1; i < array.GetLength(0) && i < array.GetLength(1); i++)
           sum = sum + array[i,i];       
    return sum;  
}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = GreateRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(myArray);
Console.WriteLine ($"Сумма диагональных элементов - {DiagSum(myArray)}");