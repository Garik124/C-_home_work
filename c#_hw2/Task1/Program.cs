// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

using static System.Console;
Clear();

int N = new Random().Next(100, 999);
WriteLine ($"число: {N}");

int M = N % 100 / 10; // берём остаток от трёхзначного числа и делим его на 10, в итоге выводим целое число без остатка (т.е. вторую цифру)
Write (M);

