﻿//Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int N=123;
int[] arr = new int[N];
Random random = new Random();
for(int i = 0; i < arr.Length; i++)
arr[i] = random.Next(0,10);
for(int i = 0;i < arr.Length; i++)
Console.Write($"{arr[i],4}");

int count = 0;
for(int i = 0; i < arr.Length; i++)
{
if( i > 10 && i < 99)
count++;
}

Console.WriteLine(count);