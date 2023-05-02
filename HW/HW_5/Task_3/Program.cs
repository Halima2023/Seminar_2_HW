// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.   [3 7 22 2 78] -> 76
/*
double[] CreateRandomArray(int size, double minValue, double maxValue)
{
    double[] num = new double [array] ;

    for (int i = 0; i < size; i++)
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;

    return array;
}

void ShowArray(double[] array)
{
    Console.Write($"New array: [{array[0]}");

    for (int i = 1; i < array.Length; i++)

        Console.Write($" {array[i]}");
    Console.Write("]");
}

double GetDiffOfNumbers(int size, double min, double max)
{
    double[] num = new double[size];
    double diff = 0;
   
    for (int i = 0; i < size; i++)
    { diff = max - min;
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
double[] array = CreateRandomArray(array);
ShowArray(array);

double diff = Math.Round(GetDiffOfNumbers(size, min, max),2);
Console.Write($" Difference between max and min is -> {diff} ");
Console.Write("Input a quantity of elements: ");
      int size = Convert.ToInt32(Console.ReadLine());
      Console.Write("Input a minimum possible element: ");
      double min = Convert.ToDouble(Console.ReadLine());
      Console.Write("Input a maximum possible element: ");
      double max = Convert.ToDouble(Console.ReadLine());
      double[] array = CreateRandomArray(size, min, max);
      ShowArray(array);
      System.Console.WriteLine();
      
      Console.WriteLine($"Difference between max and min is -> {max - min} ");
   
     double[] CreateRandomArray(int size, double minValue, double maxValue)
    {
      double[] array = new double[size];
      Random random = new Random();

      for (int i = 0; i < size; i++)
        array[i] = random.NextDouble() * (maxValue - minValue) + minValue;

      return array;
    }

     void ShowArray(double[] array)
    {
      Console.Write($"New array: [{array[0]}");

      for (int i = 1; i < array.Length; i++)

        Console.Write($", {array[i]}");
      Console.Write("]");
    }

    double GetDiffOfNumbers(double[] array)
    {
      double min = 0;
      double max = 0;
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
      }

      return max - min;
    }

    */double[] CreateRandomArray(int size, double minValue, double maxValue) 
{ 
    double[] array = new double[size]; 
    Random random = new Random(); 
 
    for (int i = 0; i < size; i++) 
    { 
        array[i] = random.NextDouble() * (maxValue - minValue) + minValue; 
        array[i] = Math.Round(array[i], 1); 
    }   
    return array; 
} 
 
 
void ShowArray(double[] array) 
{ 
    Console.Write($"New array: [{array[0]}"); 
 
    for (int i = 1; i < array.Length; i++) 
 
        Console.Write($" {array[i]}"); 
    Console.Write("]"); 
} 
 
double GetDiffOfNumbers(double[] array, double min, double max) 
{ 
     
    for (int i = 0; i < array.Length; i++) 
    {    
        if (array[i] > max) max = array[i]; 
        else if (array[i] < min) min = array[i];  
    } 
 
    return max - min; 
} 
 
Console.Write("Input a quantity of elements: "); 
int size = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a minimum possible element: "); 
double min = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Input a maximum possible element: "); 
double max = Convert.ToDouble(Console.ReadLine()); 
double[] array = CreateRandomArray(size, min, max); 
ShowArray(array); 
Console.WriteLine(); 
double diff = Math.Round(GetDiffOfNumbers(array, min, max),1); 
Console.Write($"Difference between max and min is -> {diff} ");