// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int ReadFromConsole (string message)
// {
//     System.Console.WriteLine(message);
//     return int.Parse(Console.ReadLine());
// }

double ApowB (double A, double B)
{
    double res = 0;
    if (A > 0)
    {
        res = Math.Pow(A, B);
        return res;
    }
    else
    Console.WriteLine ("fail");
    return res;
}

double result = ApowB (2, 4);
Console.WriteLine(result);
