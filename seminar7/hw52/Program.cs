﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
for(int i = 0;  i < matrix.GetLength(0); i++ )
   {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
   }
}


int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        sum = (sum + numbers[i, j]);
    }
    sum = sum / n;
    Console.Write(sum + "; ");
}
Console.WriteLine();



