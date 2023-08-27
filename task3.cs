// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] a = new int[5, 5];
double count = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        a[i, j] = new Random().Next(0, 10);
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        count += a[j, i];
    }
    Console.Write(count / 5 + "; ");
    count = 0;
}
