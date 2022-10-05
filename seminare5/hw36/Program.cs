﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size,int leftRange,  int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}
int Pos (int[] arr)
{
    int sum = 0;
    //int i = 1;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        
        {
            sum += arr[i]; 
        }
    }
    return sum;
}

int [] array = GetArray( 10, 0, 10);
 Console.WriteLine(string.Join(", ", array));
int newArray =  Pos(array);
Console.WriteLine($"сумму элементов, стоящих на нечётных позициях равна {newArray}");