// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using static System.Console;
Clear();

WriteLine ("Введите число: ");
String N = ReadLine();

// if (N[0]==N[4] || N[1]==N[3])                              //ЭТО ПЕРВОЕ РЕШЕНИЕ, НО МОЖНО РЕШИТЬ ЧРЕЗЕ bool НИЖЕ
//     Console.WriteLine($"Ваше число: {N} - палиндром.");

// else 
//     Console.WriteLine($"Ваше число: {N} - НЕ палиндром.");

bool NumberIsPalindrom (string number)
{
    return (number[0]==number[4] && number[1]==number[3]);
}


if (NumberIsPalindrom(N))                              //РЕШЕНИЕ С ПОМОЩЬЮ МЕТОДА bool
    Console.WriteLine($"Ваше число: {N} - палиндром.");

else 
    Console.WriteLine($"Ваше число: {N} - НЕ палиндром.");