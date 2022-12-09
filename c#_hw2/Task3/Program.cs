// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

using static System.Console;
Clear();

void appointmentDay(int day)
{
    if (day == 6 || day == 7)
    WriteLine ("выходной");
    else if (day < 1 || day > 7)
    WriteLine ("это не день недели");
    else
    WriteLine ("будний день");
}

Write("Введи цифру, обозначающую день недели: ");
int dayNumber = int.Parse(ReadLine());

appointmentDay(dayNumber);
WriteLine();
