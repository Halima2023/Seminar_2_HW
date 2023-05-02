//HW_6 Task_1. Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2    1, -7, 567, 89, 223-> 3

/*
 int [] array = {-4, 4, 0, 7, -5}; 
*/
int[] CreateArray(int size) 
{
int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Введите {0} число : ", i+1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
 }
void ShowArray(int [] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i] }, ");
    }
    Console.WriteLine();
}
int QuantityOfPositives(int[] array)
{
    
    int  quantity = 0;
   
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        quantity++;
    }
    return  quantity;
}
Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr = CreateArray(size); 
ShowArray(arr);
QuantityOfPositives(arr);
int res = QuantityOfPositives(arr);
Console.Write($"Количество чисел больше нуля -> {res}");