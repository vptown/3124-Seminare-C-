﻿//Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



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
    for (int i = 0; i < arr.Length; i++)
    {
        if( i > 10 && i < 99) 
        {
            sum ++; 
        }
    }
    return sum;
}

int [] array = GetArray( 123, 0, 151);
 Console.WriteLine(string.Join(", ", array));
int newArray =  Pos(array);
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] равна {newArray}");

