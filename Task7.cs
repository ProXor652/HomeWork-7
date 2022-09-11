/* //Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
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
PrintArray(Matrix); */

/* //Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = new int[m, n];

void FillArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,9);
        }
    }
}

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

Console.WriteLine("Введите координату A: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a>m && a>n)
{
 Console.WriteLine("такого числа нет");
}
else
{
 FillArray(Matrix);
 Console.WriteLine();
 PrintArray(Matrix);
} */