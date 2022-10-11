﻿// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольный

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
 

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();
   for(int i = 0;  i < matrix.GetLength(0); i++ )
   {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
   }
   return matrix;
}

void PrintMatrix(int[,] matrix)
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

int SumMainDiagonal(int[,] matrix)
{
    int sum = 0;
    int min;
    if (matrix.GetLength(0) >= matrix.GetLength(1))
    {
        min = matrix.GetLength(1);
    }
    else
    {
        min = matrix.GetLength(0);
    }


    for (int i = 0; i < min; i++)
    {
        sum = sum + matrix[i, i];
    }
    return sum;

}
int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matrix = GetMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine(SumMainDiagonal(matrix));

// int sum = 0;
// if(matr.GetLength(0) >= matr.GetLength(1))
// {
// for (int i = 0; i < matr.GetLength(1) ; i++)
// sum = sum + matr[i,i];
// }
// else
// {
// for (int i = 0; i < matr.GetLength(0) ; i++)
// sum = sum + matr[i,i];
// }

// Console.WriteLine(sum);

// int sum = 0;
// int min;
// if(matrix.GetLength(0) >= matrix.GetLength(1))
// {
// min = matrix.GetLength(1);
// }
// else
// {
//     min = matrix.GetLength(0);
// }


// for (int i = 0; i < min ; i++)
// {
// sum = sum + matrix[i,i];
// }

//Console.WriteLine(sum);