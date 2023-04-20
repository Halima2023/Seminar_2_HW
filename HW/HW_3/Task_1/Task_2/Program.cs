// HW_Task_2. Задача 21.  Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84,    A (7,-5, 0); B (1,-1,9) -> 11.53

double CubCoord (double x1, double y1,double z1, double x2, double y2, double z2)
{
  double distX = x2-x1;
  double distY = y2-y1;
  double distZ = z2-z1;
  
  double result = Math.Sqrt(distX*distX + distY*distY + distZ*distZ);
  return result;
}
Console.Write ("Введите значение x1 - ");
int x1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write ("Введите значение y1 - ");
int y1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write ("Введите значение z1 - ");
int z1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write ("Введите значение x2 - ");
int x2 = Convert.ToInt32(Console.ReadLine()); 

Console.Write ("Введите значение y2 - ");
int y2 = Convert.ToInt32(Console.ReadLine()); 

Console.Write ("Введите значение z2 - ");
int z2 = Convert.ToInt32(Console.ReadLine()); 

double rez = Math.Round(CubCoord(x1,y1,z1,x2,y2,z2),2);
Console.Write ($"Расстояние между точками 1 и 2  составляет  - {rez}");

