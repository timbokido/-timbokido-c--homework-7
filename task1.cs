// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("введите размерность двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double [,] a = new double [m, n];
for (int i=0; i<m; i++){
    for (int j=0; j<n; j++){
        a[i,j] = new Random().NextDouble() * 10-5;
        Console.Write($"{a[i,j]} ");
    }
    Console.WriteLine("");
}
