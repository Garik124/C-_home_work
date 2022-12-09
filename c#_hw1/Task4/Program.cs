int N = int.Parse(Console.ReadLine());
int current;
for (current = 1; current < N + 1; current++)
{
    if (current % 2 == 0)
    {
        Console.WriteLine(current + " ");
    }
}
