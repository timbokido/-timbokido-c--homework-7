// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] a = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        a[i, j] = new Random().Next(0, 10);
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("введите позиции элемента:");
int poz1 = Convert.ToInt32(Console.ReadLine());
int poz2 = Convert.ToInt32(Console.ReadLine());
if ((poz1 > 5) || (poz2 > 5))
    Console.WriteLine("такого числа в массиве нет");
else Console.WriteLine($"ваше число: {a[poz1 - 1, poz2 - 1]}");

