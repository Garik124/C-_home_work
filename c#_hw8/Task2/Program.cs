// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;
Clear();

int GetNumber(string message)
{
    WriteLine(message);
    return int.Parse(ReadLine());
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {

            Write($"\t{inArray[i, j]} ");
        }
        WriteLine();
    }
}

// int[] FindNumber(int[,] Array)
// {
//     int[] arr = new int[Array.GetLength(0)];
//     for (int m = 0; m < Array.GetLength(0); m++)
//     {
//         for (int i = 0; i < Array.GetLength(0); i++)
//         {
//             for (int j = 0; j < Array.GetLength(1); j++)
//             {
//                 int sum = 0;
//                 arr[m] = sum + Array[i, j];
//             }
//         }
//     }
//     return arr;
// }

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

int rows = GetNumber("Введите количество строк: ");
int cols = GetNumber("Введите количество столбцов: ");
int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
// int[] massive = FindNumber(array);
// WriteLine(String.Join(", ", massive));
int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");

