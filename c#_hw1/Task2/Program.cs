int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());

int max = A;
if (A > max) max = A;
if (B > max) max = B;
if (C > max) max = C;

Console.Write("max = ");
Console.WriteLine(max);
