// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.   [3 7 22 2 78] -> 76

double[] CreateRandomArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;

    return array;
}

void ShowArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine("]");
}

double GetDiffOfNumbers(int size, double min, double max)
{
    double[] num = new double[size];
    double diff = 0;
   
    for (int i = 0; i < size; i++)
    {
        diff = max - min;
        if (num[i] > max) max = num[i];

        else if (num[i] < min) min = num[i];
    }
    return diff;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimum possible element: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a maximum possible element: ");
double max = Convert.ToDouble(Console.ReadLine());
double[] array = CreateRandomArray(size, min, max);
ShowArray(array);

int diff = GetDiffOfNumbers(array);
Console.WriteLine($"Разница между максимальным и минимальным числами: {max - min}");

