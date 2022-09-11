//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Enter number m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number n: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-9,9);
        }
    }
}
int[,] Matrix = new int[m, n];

PrintArray(Matrix);
FillArray(Matrix);
Console.WriteLine();
PrintArray(Matrix);