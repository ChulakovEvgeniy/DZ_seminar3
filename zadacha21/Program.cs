// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координты точки A");
System.Console.Write("X=");
double x1 = Convert.ToInt64(Console.ReadLine());
System.Console.Write("Y=");
double y1 = Convert.ToInt64(Console.ReadLine());
System.Console.Write("Z=");
double z1 = Convert.ToInt64(Console.ReadLine());

System.Console.WriteLine("Введите координты точки B");
System.Console.Write("X=");
double x2 = Convert.ToInt64(Console.ReadLine());
System.Console.Write("Y=");
double y2 = Convert.ToInt64(Console.ReadLine());
System.Console.Write("Z=");
double z2 = Convert.ToInt64(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

System.Console.WriteLine(distance);

