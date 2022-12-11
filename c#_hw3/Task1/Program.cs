// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using static System.Console;
Clear();

WriteLine ("Введите число: ");
String N = ReadLine();

if (N[0]==N[4] || N[1]==N[3])
    Console.WriteLine($"Ваше число: {N} - палиндром.");

else 
    Console.WriteLine($"Ваше число: {N} - НЕ палиндром.");

