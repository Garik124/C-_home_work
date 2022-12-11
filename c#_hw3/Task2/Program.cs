// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using static System.Console;
Clear();

Write ("Enter ax = ");
double ax = Convert.ToDouble(ReadLine());
Write ("Enter ay = ");
double ay = Convert.ToDouble(ReadLine());
Write ("Enter az = ");
double az = Convert.ToDouble(ReadLine());

Write ("Enter bx = ");
double bx = Convert.ToDouble(ReadLine());
Write ("Enter by = ");
double by = Convert.ToDouble(ReadLine());
Write ("Enter bz = ");
double bz = Convert.ToDouble(ReadLine());

double R = Math.Sqrt (Math.Pow(ax-bx, 2) + Math.Pow (ay-by, 2) + Math.Pow (az-bz, 2));
WriteLine (R);
