// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using static System.Console;
Clear();

WriteLine ("Введите число: ");
int N = int.Parse(ReadLine());
int i = 1;
int count = 1;

while (count < N + 1)
{
    WriteLine(i*i*i);
    i++;
    count++;
}
