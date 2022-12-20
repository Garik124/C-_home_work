//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void CheckNumberInMassive(int[,] massive, int N)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (N == massive[i, j])
            {
                WriteLine($"число находится в {i} строке в {j} стобце");
            }
            else;
            WriteLine("такого числа нет");

        break;
        }
        
    }
}

int rows = GetNumber("Введите количество строк: ");
int cols = GetNumber("Введите количество столбцов: ");
int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
int N = GetNumber("Введите число которое нужно найти: ");
CheckNumberInMassive(array, N);