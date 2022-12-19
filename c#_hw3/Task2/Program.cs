// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using static System.Console;
Clear();

// double DistaceBetweenTwoPoint((double x, double y, double z) point1, (double x, double y, double z) point2)// АЛЬТЕРНАТИВНЫЙ ВАРИАНТ РЕШЕНИЯ С КОРТЕЖАМИ
// {
//     return Math.Sqrt(Math.Pow((point2.x - point1.x), 2) + Math.Pow((point2.y - point1.y), 2)
//      + Math.Pow((point2.z - point1.z), 2));
// }

// (double x, double y, double z) GetPointCoord()
// {
//     (double x, double y, double z) point;
//     Write("Enter ax = ");
//     point.x = Convert.ToDouble(ReadLine());
//     Write("Enter ay = ");
//     point.y = Convert.ToDouble(ReadLine());
//     Write("Enter az = ");
//     point.z = Convert.ToDouble(ReadLine());

//     return point;
// }

// (double x, double y, double z) point1 = GetPointCoord();
// (double x, double y, double z) point2 = GetPointCoord();

// double answer = DistaceBetweenTwoPoint(point1, point2);
// WriteLine(answer);

Write("Enter ax = ");
double ax = Convert.ToDouble(ReadLine());
Write("Enter ay = ");
double ay = Convert.ToDouble(ReadLine());
Write("Enter az = ");
double az = Convert.ToDouble(ReadLine());

Write("Enter bx = ");
double bx = Convert.ToDouble(ReadLine());
Write("Enter by = ");
double by = Convert.ToDouble(ReadLine());
Write("Enter bz = ");
double bz = Convert.ToDouble(ReadLine());

double R = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
WriteLine(R);
