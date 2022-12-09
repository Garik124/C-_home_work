int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

if (A > B)
{
    Console.Write($"{A} - max, {B} - min");
}

else if (A < B)
{
    Console.Write($"{B} - max, {A} - min");
}

//знак $ необходим для более структурированного ввода информации: все что написано после этого знака
//в кавычках ("") будет браться из переменных, все что без них будет выводиться как ты написал